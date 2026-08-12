using ContactApp.Model;
using Microsoft.Data.SqlClient;

namespace ContactApp.Repository
{
    public class ContactRepository
    {
        private readonly string connectionString;

        public ContactRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }


        // GET ALL
        public List<Contact> GetAll()
        {
            List<Contact> contacts = new List<Contact>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Email, Phone FROM Contacts";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contact contact = new Contact();

                            contact.Id = Convert.ToInt32(reader["Id"]);
                            contact.Name = reader["Name"].ToString();
                            contact.Email = reader["Email"].ToString();
                            contact.Phone = reader["Phone"].ToString();

                            contacts.Add(contact);
                        }
                    }
                }
            }

            return contacts;
        }


        // GET BY ID
        public Contact? GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT Id, Name, Email, Phone FROM Contacts WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contact
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }


        // GET BY PHONE
        public Contact? GetByPhone(string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT Id, Name, Email, Phone FROM Contacts WHERE Phone = @Phone";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", phone);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contact
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }


        // ADD
        public void Add(Contact contact)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    "INSERT INTO Contacts (Name, Email, Phone) " +
                    "VALUES (@Name, @Email, @Phone)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", contact.Name);
                    command.Parameters.AddWithValue("@Email", contact.Email);
                    command.Parameters.AddWithValue("@Phone", contact.Phone);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }


        // UPDATE
        public bool Update(Contact contact)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    "UPDATE Contacts " +
                    "SET Name = @Name, Email = @Email, Phone = @Phone " +
                    "WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", contact.Id);
                    command.Parameters.AddWithValue("@Name", contact.Name);
                    command.Parameters.AddWithValue("@Email", contact.Email);
                    command.Parameters.AddWithValue("@Phone", contact.Phone);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


        // DELETE
        public void Delete(Contact contact)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Contacts WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", contact.Id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}