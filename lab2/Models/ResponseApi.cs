using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Models
{
  
    public class ResponseApi 
    {
        public bool IsSuccess {  get; set; }
        public string Notification { get; set; }
        public object Data {  get; set; }   
    }
}
