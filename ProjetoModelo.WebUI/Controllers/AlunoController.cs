using Microsoft.Reporting.WebForms;
using ProjetoModelo.Domain.API;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.WebUI.Models;
using System.IO;
using System.Web.Hosting;
using System.Web.Mvc;

namespace ProjetoModelo.WebUI.Controllers
{
    public class AlunoController : Controller
    {
        private AlunoRepository repository;

        public AlunoController()
        {
            repository = new AlunoRepository();
        }

        public ViewResult Index()
        {
            return View(new AlunosListView { Alunos = repository.Alunos });
        }

        public ViewResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken, HttpPost]
        public ActionResult Create(Aluno aluno)
        {
            repository.InsertAluno(aluno);
            return RedirectToAction("Index");
        }

        public ViewResult Edit(int id)
        {
            return View(repository.GetAluno(id));
        }

        [ValidateAntiForgeryToken, HttpPost]
        public ActionResult Edit(Aluno aluno)
        {
            repository.UpdateAluno(aluno);
            return RedirectToAction("Visualiza", new { id = aluno.Id });
        }

        public ActionResult Delete(int id)
        {
            repository.DeleteAluno(id);
            return RedirectToAction("Index");
        }

        public ViewResult Visualiza(int id)
        {
            return View(repository.GetAluno(id));
        }

        public ActionResult Report(int id)
        {
            var report = new LocalReport();
            var path = Path.Combine(Server.MapPath("~/Reports"), "AlunoReport.rdlc");

            if (System.IO.File.Exists(path))
                report.ReportPath = path;
            else
                return RedirectToAction("Index", new { Id = id });

            var aluno = repository.GetAlunoReport(id);

            ReportDataSource rd = new ReportDataSource("DataSet1", aluno);

            report.DataSources.Add(rd);

            const string reportType = "PDF";

            string deviceInfo =
                "<DeviceInfo>" +
                "  <OutputFormat>" + reportType + "</OutputFormat>" +
                "  <PageWidth>8.5in</PageWidth>" +
                "  <PageHeight>11in</PageHeight>" +
                "  <MarginTop>0.5in</MarginTop>" +
                "  <MarginLeft>1in</MarginLeft>" +
                "  <MarginRight>1in</MarginRight>" +
                "  <MarginBottom>0.5in</MarginBottom>" +
                "</DeviceInfo>";

            byte[] renderedBytes;

            renderedBytes = report.Render(
                reportType,
                deviceInfo,
                out string mimeType,
                out string encoding,
                out string fileNameExtension,
                out string[] streams,
                out Warning[] warnings);

            return File(renderedBytes, mimeType);
        }
    }
}