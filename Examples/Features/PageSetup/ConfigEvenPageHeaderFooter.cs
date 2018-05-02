﻿using GrapeCity.Documents.Excel.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace GrapeCity.Documents.Excel.Examples.Features.PageSetup
{
    public class ConfigEvenPageHeaderFooter : ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Excel.Workbook workbook)
        {
            var fileStream = this.GetTemplateStream("PageSetup Demo.xlsx");
            workbook.Open(fileStream);
            IWorksheet worksheet = workbook.Worksheets[0];

            //Set even page headerfooter
            worksheet.PageSetup.OddAndEvenPagesHeaderFooter = true;

            worksheet.PageSetup.EvenPage.CenterHeader.Text = "&T";
            worksheet.PageSetup.EvenPage.RightFooter.Text = "&D";

            //Set even page headerfooter's graphic
            worksheet.PageSetup.EvenPage.LeftFooter.Text = "&G";
            System.IO.Stream stream = this.GetResourceStream("logo.png");
            worksheet.PageSetup.EvenPage.LeftFooter.Picture.SetGraphicStream(stream, ImageType.PNG);

        }
    }
}