using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ConditionallyHideSumsInGroupRows {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        GridGroupSummaryItem summaryMin;
        GridGroupSummaryItem summaryMax;
        private void Form1_Load(object sender, EventArgs e) {
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);


            summaryMin = (GridGroupSummaryItem)gridView1.GroupSummary.Add(SummaryItemType.Min, "Unit Price");
            summaryMax = (GridGroupSummaryItem)gridView1.GroupSummary.Add(SummaryItemType.Max, "Unit Price");
            gridView1.Columns["Discontinued"].Group();
            gridView1.GroupFormat = "{0}: [#image]{1} "; // summaries are hidden for simpler string composing in CustomDrawGroupRow
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            GridGroupRowInfo info = (GridGroupRowInfo)e.Info;
            if(info.Column.FieldName == "Discontinued") {
                GridGroupSummaryItem summary;
                switch((bool)info.EditValue) {
                    case true:
                        summary = summaryMax;
                        break;
                    case false:
                        summary = summaryMin;
                        break;
                    default:
                        return;
                }
                string summaryText = gridView1.GetGroupSummaryDisplayText(e.RowHandle, summary);
                info.GroupText += summaryText;
            }
        }
    }
}