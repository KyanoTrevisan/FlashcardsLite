using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcardslite
{
    public class StudySet
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Term} - {Definition}";
        }
    }
}
