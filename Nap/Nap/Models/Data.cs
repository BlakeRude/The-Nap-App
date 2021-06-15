using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Nap.Models
{
    public class Data
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Info { get; set; }
        public string Desc { get; set; }
    }
}
