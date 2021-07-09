using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oracleTest.DatabaseTables
{
    class Rule
    {
        int ruleId;
        int discount;
        DateTime startTime;
        DateTime endTime;

        public Rule(int r_id, int dis, DateTime s_time, DateTime e_time)
        {
            this.ruleId = r_id;
            this.discount = dis;
            this.startTime = s_time;
            this.endTime = e_time;
        }
    }


    class RuleOnFilmType : Rule
    {
        List<string> filmType;

        public RuleOnFilmType(int r_id, int dis, DateTime s_time, DateTime e_time, List<string> f_type)
            : base(r_id, dis, s_time, e_time)
        {
            this.filmType = f_type;
        }
    }

    class RuleOnPoints : Rule
    {
        int rulePoints;

        public RuleOnPoints(int r_id, int dis, DateTime s_time, DateTime e_time, int r_points)
            : base(r_id, dis, s_time, e_time)
        {
            this.rulePoints = r_points;
        }
    }
}
