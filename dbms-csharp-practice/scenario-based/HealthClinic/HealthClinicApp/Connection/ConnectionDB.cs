using Microsoft.Data.SqlClient;

public class ConnectionDB
{
    private static string connectionString = "Server=localhost\\SQLExpress;Database = HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True";
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}