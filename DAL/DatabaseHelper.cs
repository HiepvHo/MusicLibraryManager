using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MusicLibraryManager.DAL
{
    public class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MusicLibraryDB"].ConnectionString;

        /// <summary>
        /// Lấy connection string
        /// </summary>
        public static string GetConnectionString()
        {
            return connectionString;
        }

        /// <summary>
        /// Kiểm tra kết nối database
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Thực thi stored procedure không trả về kết quả
        /// </summary>
        public static int ExecuteNonQuery(string procedureName, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thực thi {procedureName}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thực thi stored procedure và trả về giá trị đơn (scalar)
        /// </summary>
        public static object ExecuteScalar(string procedureName, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thực thi {procedureName}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thực thi stored procedure và trả về DataTable
        /// </summary>
        public static DataTable ExecuteQuery(string procedureName, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thực thi {procedureName}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thực thi câu SQL query trực tiếp (dùng cho các trường hợp đặc biệt)
        /// </summary>
        public static DataTable ExecuteQueryDirect(string sqlQuery, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thực thi query: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thực thi stored procedure với output parameter
        /// </summary>
        public static object ExecuteWithOutputParameter(string procedureName, SqlParameter[] parameters, string outputParamName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return cmd.Parameters[outputParamName].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thực thi {procedureName}: {ex.Message}", ex);
            }
        }
    }
}

