﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobDescriptionRepository : BaseADO,IDataRepository<CompanyJobDescriptionPoco>
    {
        public void Add(params CompanyJobDescriptionPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                foreach (CompanyJobDescriptionPoco poco in items)
                {
                    command.CommandText = @"INSERT INTO [dbo].[Company_Jobs_Descriptions] ([Id],[Job],[Job_Name],[Job_Descriptions]) VALUES (@Id,@Job,@Job_Name,@Job_Descriptions) ";
                    command.Parameters.AddWithValue("@Id", poco.Id);
                    command.Parameters.AddWithValue("@Job", poco.Job);
                    command.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    command.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);                    
                    conn.Open();
                    int rowEffected = command.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobDescriptionPoco> GetAll(params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[1500];
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Company_Jobs_Descriptions]", conn);
                int position = 0;
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CompanyJobDescriptionPoco poco = new CompanyJobDescriptionPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    if(!reader.IsDBNull(2))
                    {
                        poco.JobName = reader.GetString(2);
                    }
                    else
                    {
                        poco.JobName = null;
                    }
                    if (!reader.IsDBNull(3))
                    {
                        poco.JobDescriptions = reader.GetString(3);
                    }
                    else
                    {
                        poco.JobDescriptions = null;
                    }
                    if (!reader.IsDBNull(4))
                    {
                        poco.TimeStamp = (byte[])reader[4];
                    }
                    else
                    {
                        poco.TimeStamp = null;
                    }                
                    pocos[position] = poco;
                    position++;
                }
                conn.Close();

            }
            return pocos.Where(a => a != null).ToList();
        }

        public IList<CompanyJobDescriptionPoco> GetList(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobDescriptionPoco GetSingle(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobDescriptionPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                foreach (CompanyJobDescriptionPoco poco in items)
                {
                    command.CommandText = @"DELETE FROM [dbo].[Company_Jobs_Descriptions] WHERE Id=@Id";
                    command.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    int rowEffected = command.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }

        public void Update(params CompanyJobDescriptionPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                foreach (CompanyJobDescriptionPoco poco in items)
                {
                    command.CommandText = @"UPDATE [dbo].[Company_Jobs_Descriptions] SET Job=@Job,Job_Name=@Job_Name,Job_Descriptions=@Job_Descriptions WHERE Id=@Id ";
                    command.Parameters.AddWithValue("@Job", poco.Job);
                    command.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    command.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);
                    command.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    int rowEffected = command.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }
    }
}
