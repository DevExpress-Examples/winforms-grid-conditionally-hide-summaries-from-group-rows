Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace ConditionallyHideSumsInGroupRows

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private summaryMin As GridGroupSummaryItem

        Private summaryMax As GridGroupSummaryItem

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim tmp_XViewsPrinting = New Design.XViewsPrinting(gridControl1)
            summaryMin = CType(gridView1.GroupSummary.Add(SummaryItemType.Min, "Unit Price"), GridGroupSummaryItem)
            summaryMax = CType(gridView1.GroupSummary.Add(SummaryItemType.Max, "Unit Price"), GridGroupSummaryItem)
            gridView1.Columns("Discontinued").Group()
            gridView1.GroupFormat = "{0}: [#image]{1} " ' summaries are hidden for simpler string composing in CustomDrawGroupRow
        End Sub

        Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As Views.Base.RowObjectCustomDrawEventArgs)
            Dim info As GridGroupRowInfo = CType(e.Info, GridGroupRowInfo)
            If Equals(info.Column.FieldName, "Discontinued") Then
                Dim summary As GridGroupSummaryItem
                Select Case CBool(info.EditValue)
                    Case True
                        summary = summaryMax
                    Case False
                        summary = summaryMin
                    Case Else
                        Return
                End Select

                Dim summaryText As String = gridView1.GetGroupSummaryDisplayText(e.RowHandle, summary)
                info.GroupText += summaryText
            End If
        End Sub
    End Class
End Namespace
