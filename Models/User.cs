using System;
namespace project_sw.Models
{
    public class User
    {
        public int CC { get ; set;}
        public String pass {
            get{return pass;}
            set{ if(value.Length>70)return; pass=value;
            }
        }
        public  String email {
            get{return email;}
            set{if(!value.Contains("@")) return; email=value; } }
    }
}