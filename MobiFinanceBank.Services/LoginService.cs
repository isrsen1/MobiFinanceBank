using HashLibrary;
using MobiFinanceBank.DAL.Repositories;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiFinanceBank.Services
{
    public class LoginService : ILoginService
    {
        private readonly IEmployeeRepository employeeRepository;
        private HashLibrary.HashedPassword hash;
 
        /// <summary>
        /// Login service constructor
        /// </summary>
        /// <param name="_employeeRepository">Sender</param>
        public LoginService(IEmployeeRepository _employeeRepository)
        {          
              this.employeeRepository = _employeeRepository;
            
        }

        /// <summary>
        /// Base64Decoder to get the hashed value
        /// </summary>
        /// <param name="base64EncodedHash">Encoded hash</param>
        public static string Base64Decode(string base64EncodedHash)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedHash);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        /// <summary>
        /// Queries the database and checks if the entered plaintext password matches the record
        /// </summary>
        /// <param name="username">Entered Username</param>
        /// <param name="password">Plaintext password args</param>
        public Employee CheckCredentials(string username, string password)
        {
             //Returns the employee from the database by the username
            var employee = this.employeeRepository.GetEmployeeByUserName(username);
            //decodes the returned data into UTF8 data appropriate for the hasher
            var hashDecode = Base64Decode(employee.PasswordHash);
            var saltDecode = Base64Decode(employee.PasswordSalt);
            
            try
            {
                //example of hash and password after decoding             
                // Hash = "O_¸¯°íó7ÚS§ÊįāĨkÙZµį4g}BÞo.óDxßT";
                // Salt = "¥ĎP¢ċÎ³ðsĤĩçÍĴÃČðp×}õĐ­£ŀ_`ð?îy=";

                //passes the decoded data into the HashedPassword class constructor
                hash = new HashLibrary.HashedPassword(hashDecode, saltDecode);    
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }     
            try
            {
                //checks the hash against the plaintext
                if (hash.Check(password)==false)
                {
                    MessageBox.Show("Šifra je neispravna! Pokušajte ponovo.");
                }
                if (employee.IsActive == false)
                {
                    MessageBox.Show("Zaposlenik nije aktivan, kontaktirajte administratora.");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            if (employee != null && hash.Check(password) && employee.IsActive==true)
            {
                return employee;              
            }
            else return null;
            
        }
    }
}
