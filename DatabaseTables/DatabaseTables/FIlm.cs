using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oracleTest.DatabaseTables
{
    class Film
    {
        int filmId;
        string filmName;
        string filmDescription;
        int filmDuration;
        public Film(int f_id, string f_name, string f_desc, int f_dur)
        {
            this.filmId = f_id;
            this.filmName = f_name;
            this.filmDescription = f_desc;
            this.filmDuration = f_dur;
        }
    }

    class FilmType : Film
    {
        List<string> filmType;

        public FilmType(int f_id, string f_name, string f_desc, int f_dur, List<string> f_type)
            : base(f_id, f_name, f_desc, f_dur)
        {
            this.filmType = f_type;
        }
    }


    class FilmWorkers : Film
    {
        string workerName;
        string workerRole;
        public FilmWorkers(int f_id, string f_name, string f_desc, int f_dur, string worker_name, string worker_role)
            : base(f_id, f_name, f_desc, f_dur)
        {
            this.workerName = worker_name;
            this.workerRole = worker_role;
        }
    }
}


