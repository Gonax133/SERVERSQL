using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserIU
{
    public class review
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PaperTitle { get; set; }


        /* public int ReviewID { get; set; }
         public int PaperID { get; set; }
         public int ReviewerID { get; set; }
        */

        public double AppropiatnessOfTopic { get; set; }

        public double TimelinessOfTopic { get; set; }

        public double SupportiveEvidence { get; set; }

        public double TechnicalQuality { get; set; }

        public double ScopeOfCoverage { get; set; }

        public double CitationOfPreviousWork { get; set; }


        public double Originality { get; set; }

        public string? ContentComments { get; set; }

        public double OrganizationOfPaper { get; set; }

        public double ClarityOfMainMessage { get; set; }

        public double Mechanics { get; set; }

        public string? WrittenDocumentComments { get; set; }

        public double SuitabilityForPresentation { get; set; }

        public double PotentialInterestInTopic { get; set; }

        public string? PotentialForOralPresentationComments { get; set; }
        public double OverallRating { get; set; }
        public string? OverallRatingComments { get; set; }

        public double ComfortLevelTopic { get; set; }
        public double ComfortLevelAcceptability{ get; set; }
        public int Complete { get; set; }














    }
}
