using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEInfoCURD.Models
{
    public class MovieDataaccessLayer
    {
        string connectionString = "Data Source=CHI-CL-79T8CG2\\SQLEXPRESS;Initial Catalog=MoviesData;Integrated Security=True";
        //To View all Movie details    
        public IEnumerable<Movies> GetAllMovieDetails()
        {
            List<Movies> lstmovies = new List<Movies>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllMovieDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Movies MoviesDetails = new Movies();
                    MoviesDetails.ID = Convert.ToInt32(rdr["MovieID"]);
                    MoviesDetails.Name = rdr["Name"].ToString();
                    MoviesDetails.Year = rdr["YearOfRelease"].ToString();
                    MoviesDetails.Plot = rdr["Plot"].ToString();
                    MoviesDetails.Image = rdr["Image"].ToString();
                    MoviesDetails.Actors = rdr["Actors"].ToString();
                    MoviesDetails.Producer = rdr["Producer"].ToString();
                    lstmovies.Add(MoviesDetails);
                }
                con.Close();
            }
            return lstmovies;
        }
        //GetActor details
        public Actordetails GetActorDetails(int? id)
        {
            Actordetails Actordetails = new Actordetails();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "select * from Actors where ActorID=" + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Actordetails.ID = Convert.ToInt32(rdr["ActorID"]);
                    Actordetails.Name = rdr["ActorName"].ToString();
                    Actordetails.DOB = rdr["DOB"].ToString();
                    Actordetails.Biodata = rdr["Bio"].ToString();
                }
                con.Close();
            }
            return Actordetails;
        }
        //Get Director details
        public DirectorDetails GetDirectorDetails(int? id)
        {
            DirectorDetails Directordetails = new DirectorDetails();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "select * from Producers where ProducerID=" + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Directordetails.ID = Convert.ToInt32(rdr["ProducerID"]);
                    Directordetails.Name = rdr["Name"].ToString();
                    Directordetails.DOB = rdr["DOB"].ToString();
                    Directordetails.Biodata = rdr["Bio"].ToString();
                }
                con.Close();
            }
            return Directordetails;
        }
        //To Add new Movie record    
        public void AddMovieDetails(Movies MovieDetails)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddMovieDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", MovieDetails.ID);
                cmd.Parameters.AddWithValue("@Name", MovieDetails.Name);
                cmd.Parameters.AddWithValue("@YearOfRelease", MovieDetails.Year);
                cmd.Parameters.AddWithValue("@Plot", MovieDetails.Plot);
                cmd.Parameters.AddWithValue("@Image", MovieDetails.Image);
                cmd.Parameters.AddWithValue("@Actors", MovieDetails.Actors);
                cmd.Parameters.AddWithValue("@Producer", MovieDetails.Producer);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar Movie  
        public void UpdateMovieDetails(Movies MovieDetails)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateMovie", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", MovieDetails.ID);
                cmd.Parameters.AddWithValue("@Name", MovieDetails.Name);
                cmd.Parameters.AddWithValue("@YearOfRelease", MovieDetails.Year);
                cmd.Parameters.AddWithValue("@Plot", MovieDetails.Plot);
                cmd.Parameters.AddWithValue("@Image", MovieDetails.Image);
                cmd.Parameters.AddWithValue("@Actors", MovieDetails.Actors);
                cmd.Parameters.AddWithValue("@Producer", MovieDetails.Producer);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular Movie  
        public Movies GetMovieData(int? id)
        {
            Movies MoviesDetails = new Movies();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Movies WHERE MovieID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MoviesDetails.ID = Convert.ToInt32(rdr["MovieID"]);
                    MoviesDetails.Name = rdr["Name"].ToString();
                    MoviesDetails.Year = rdr["YearOfRelease"].ToString();
                    MoviesDetails.Plot = rdr["Plot"].ToString();
                    MoviesDetails.Image = rdr["Image"].ToString();
                    MoviesDetails.Actors = rdr["Actors"].ToString();
                    MoviesDetails.Producer = rdr["Producer"].ToString();
                }
            }
            return MoviesDetails;
        }
        //To Delete the record on a particular Movie  
        public void DeleteMovie(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteMovieDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
