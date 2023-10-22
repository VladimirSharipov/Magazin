using Magazin.Model;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace Magazin.Controller
{
	static class ControllerDB
    {
		 static string connection = "Data Source=localhost;Initial Catalog=Magazine; Connect Timeout=50;Trusted_Connection=True;";
		public  async static Task<bool> InsUSers(Model.User user)
		{
			string zaproc ;
			bool result = false;
			await Task.Run(async () =>
			{
				try
				{
					using (SqlConnection conn = new SqlConnection())
					{
						conn.ConnectionString = connection;
						conn.Open();

						zaproc = $"insert into Magazine.dbo.USERS(ID,LOGIN,PASSWORD,DESCRIPTION,CREATE_DATE) values((select ISNULL(MAX(ID),0)+1   FROM  Magazine.dbo.USERS), '{user.Login}','{user.Password}','{user.Description}',GETDATE() );";
						SqlCommand cmd = new SqlCommand(zaproc);
						cmd.CommandTimeout = 60000;
						cmd.Connection = conn;

						cmd.ExecuteNonQuery();
						result = true;
					}
				}
				catch (Exception ex)

				{
					await Helper.Erorr($"{ex.Message},{ex.StackTrace}");
					result = false;
					//ex.StackTrace
				}

			});
						return result;	
		}
		public  static List<Model.User> GetUsers()
		{ 

			string zaproc;
			List<Model.User> users = new();
			
				try
				{
					using (SqlConnection conn = new SqlConnection())
					{
						conn.ConnectionString = connection;
						conn.Open();
						zaproc = "SELECT *  FROM [Magazine].[dbo].[USERS] us   left JOIN [Magazine].[dbo].[ROLES] rol on rol.USER_ID = us.ID;";
						SqlCommand cmd = new SqlCommand(zaproc);
						cmd.CommandTimeout = 60000;
						cmd.Connection = conn;


						using (SqlDataReader a = cmd.ExecuteReader())
						{

							while (a.Read())
							{
								Model.User user = new Model.User();
								user.Id = (int)a.GetInt64(0);
								user.Login = a.GetString(1);
								user.Password = a.GetString(2);
								user.Description = a.IsDBNull(3) ? "" : a.GetString(3);
								user.CreateDate = a.GetDateTime(4);
								user.Name = a.IsDBNull(5) ? "" : a.GetString(5);
								user.RolesId = a.IsDBNull(6) ? 0 : a.GetInt64(6);
								users.Add(user);
							}

						}


					}
				}
				catch (Exception ex)
				{
					 Helper.Erorr($"{ex.Message},{ex.StackTrace}");
					//ex.StackTrace
				}
	
			
			
			
			return users;
		}
		public async static Task<List<HHdModel>> GetHHD()
		{
			string zaproc;
			List<HHdModel> hhd = new();
			await Task.Run(async () =>
			{
				try
				{
					using (SqlConnection conn = new SqlConnection())
					{
						conn.ConnectionString = connection;
						conn.Open();
						zaproc = "select  ID ,TYPE ,MODEL,GB from Magazine.dbo.HHD;";
						SqlCommand cmd = new SqlCommand(zaproc);
						cmd.CommandTimeout = 60000;
						cmd.Connection = conn;


						using (SqlDataReader a = cmd.ExecuteReader())
						{

							while (a.Read())
							{
								HHdModel h = new HHdModel();

								h.Id = (int)a.GetInt64(0);
								h.Type = (TypeHHD)a.GetInt32(1);
								h.Model = a.GetString(2);
								h.Gb = a.GetInt32(3);
								hhd.Add(h);


							}

						}


					}
				}
				catch (Exception ex)
				{
					await Helper.Erorr($"{ex.Message},{ex.StackTrace}");
					//ex.StackTrace
				}
			});
			return hhd;
		}
		public async static Task<List<MatcherPlat>> GetMatherPlat()
			
		{
			string zaproc;
			List<MatcherPlat> Mp = new();
			await Task.Run(async () =>
			{

				try
				{
				using (SqlConnection conn = new SqlConnection())
				{
					conn.ConnectionString = connection;
					conn.Open();
					zaproc = "select  ID ,TYPE ,MODEL from Magazine.dbo.Motherboard;";
					SqlCommand cmd = new SqlCommand(zaproc);
					cmd.CommandTimeout = 60000;
					cmd.Connection = conn;


					using (SqlDataReader a = cmd.ExecuteReader())
					{

						while (a.Read())
						{
							MatcherPlat m = new MatcherPlat();

							m.Id= (int)a.GetInt64(0);	
							m.Type = (TypeMp)a.GetInt32(1);
							m.Model = a.GetString(2);
							Mp.Add(m);


						}

					}


				}
			}
			catch (Exception ex)
			{
				await Helper.Erorr($"{ex.Message},{ex.StackTrace}");
				//ex.StackTrace
			}
			});
			
			return Mp;
		}
		//без статика инециал
		public static bool XmlSerializ(Type a ,string path,object List)
        {
            if (File.Exists (path))//есть такой файл
            {
                File.Delete(path);//удалить файл 

            }
            
            XmlSerializer xml = new XmlSerializer(a);
            try
            {
                using TextWriter writer = new StreamWriter(path);
                xml.Serialize(writer, List);
            }
            catch(Exception ex)
            {
				Helper.Erorr($"{ex.Message},{ex.StackTrace}");
				return false;
				
			}
            return true;
        }
       public static object XmlDeSerializ(string path,Type a)
        {
            object o = null;
            if (File.Exists(path))
            {
                XmlSerializer xml = new XmlSerializer(a);
                using (TextReader g = new StreamReader(path))
                {
                    o = xml.Deserialize(g);

                }

            }

            return o;
        }
        public static  bool Login(string lg ,string ps,out long RolesId )
        {
            //string path = "C:\\Users\\user\\ppppppppppppp.xml";
			bool result = false;
			RolesId = 0;
            List<Model.User> users = new List<Model.User>();
			users =  GetUsers();
			//users = XmlDeSerializ(path, typeof(List<Model.User>)) as List<Model.User>;
			//User1 = users.where(w => Login == string.Empty || Password == string.Empty)
			//return User1;
			//

			try
			{
				if (users != null && users.Any(w => w.Login == lg && w.Password == ps))
				{
					result = true;
					Model.User us  = users.FirstOrDefault(w => w.Login == lg && w.Password == ps);
					RolesId = us.RolesId;


				}
			}
			catch(Exception ex )
			{
				 Helper.Erorr($"{ex.Message},{ex.StackTrace}");
				return false;
			}
			return result;
			
		}
	

	}
}
