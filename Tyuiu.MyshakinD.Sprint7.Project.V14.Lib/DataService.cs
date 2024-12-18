using System.Net;

namespace Tyuiu.MyshakinD.Sprint7.Project.V14.Lib {
    public class DataService {

        public static bool ConnectionAvailable() {
            try
            {
                HttpWebRequest httpReq = (HttpWebRequest)HttpWebRequest.Create("http://www.google.com");
                HttpWebResponse httpWeb = (HttpWebResponse)httpReq.GetResponse();

                if (HttpStatusCode.OK == httpWeb.StatusCode)
                {
                    httpWeb.Close();
                    return true;
                }
                else
                {
                    httpWeb.Close();
                    return false;
                }
            }
            catch (WebException)
            {
                return false;
            }
}

    }
}
