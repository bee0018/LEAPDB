using IronPdf;

namespace LEAP_DB_Web.Pages.Reports.Util
{
    public class StudentPDFGenerator
    {
        /*
        * Generate the student report for the student and making a PDF
        */
        public static void GenerateStudentReport()
        {
            var document = new ChromePdfRenderer();

            // Subject to change
            // Currently has the LEAP logo on the PDF document 
            string report = @"
                            <p>
                                <img src=""https://leap-au.azurewebsites.net/Content/assets/img/Leap%20and%20Learn%20Center%20Logo%20-%20tagline%20-%20dark%20navy%20-%20trans%20bg%20-%20png%20.svg"">
                            </p>";
            document.RenderHtmlAsPdf(report).SaveAs("output.pdf");
        }
    }
}
