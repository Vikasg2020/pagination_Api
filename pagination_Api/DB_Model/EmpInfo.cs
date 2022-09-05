using System.ComponentModel.DataAnnotations;

namespace pagination_Api.DB_Model
{
    public class EmpInfo
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public long age { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public string depart { get; set; }

        public string address { get; set; }


    }
}
