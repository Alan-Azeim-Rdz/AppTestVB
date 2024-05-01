Imports System.Drawing.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Office2010.Drawing
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System

Public Class Form1

    Dim id As Integer

    Public Sub New()
        InitializeComponent()
        id = 0
        lstvData.FullRowSelect = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim x As MyItem
        'i++   -->   i = i + 1
        Dim description As String = txtDescription.Text
        id = id + 1
        Dim Price As Random = New Random()

        x = New MyItem(id, description, Math.Round(Price.NextDouble() * 1000, 2))
        lstItems.Items.Add(x.ToString())

        'ListView -- ListViewItems -- SubItems

        For i = 1 To 100
            Dim row As ListViewItem = New ListViewItem(x.Id)
            row.SubItems.Add(x.Description)
            row.SubItems.Add(x.Price)
            lstvData.Items.Add(row)
            x.Id = x.Id + 1
            x.Price = Math.Round(Price.NextDouble() * 1000, 2)

        Next
        UpdateLabel()
        UpdateTotal()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstvData.SelectedItems.Count = 0 Then
            Return
        End If
        For Each item As ListViewItem In lstvData.SelectedItems
            lstvData.Items.Remove(item)
        Next
        UpdateLabel()
        UpdateTotal()
    End Sub

    Sub UpdateLabel()
        lblCount.Text = lstvData.Items.Count
    End Sub
    Sub UpdateTotal()
        Dim Total As Decimal = 0
        For Each item As ListViewItem In lstvData.Items
            Total = Total + Decimal.Parse(item.SubItems(2).Text)
        Next
        LblTotal.Text = Total
    End Sub

    Private Sub CreteFileBtn_Click(sender As Object, e As EventArgs) Handles CreteFileBtn.Click
        Dim savefile As SaveFileDialog = New SaveFileDialog()
        savefile.Filter = "Exel Files|*.xlsx"
        savefile.Title = "Save the Text File in Exel"

        If savefile.ShowDialog() = DialogResult.OK Then
            Dim Namefile As String = savefile.FileName

            Using DocumentExel As SpreadsheetDocument = SpreadsheetDocument.Create(Namefile, SpreadsheetDocumentType.Workbook)

                Dim workbook As WorkbookPart = DocumentExel.AddWorkbookPart()
                workbook.Workbook = New Workbook()

                ' Agregar la hoja de cálculo
                Dim worksheetPart As WorksheetPart = workbook.AddNewPart(Of WorksheetPart)()
                worksheetPart.Worksheet = New Worksheet(New SheetData())

                ' Añadir la hoja de cálculo al workbook
                Dim sheets As Sheets = workbook.Workbook.AppendChild(New Sheets())
                Dim sheet As New Sheet With {
                    .id = workbook.GetIdOfPart(worksheetPart),
                    .SheetId = 1,
                    .Name = "Hoja1"
                 }
                sheets.Append(sheet)

                ' Obtener los datos de la ListView y escribirlos en el archivo Excel
                Dim sheetData As SheetData = worksheetPart.Worksheet.GetFirstChild(Of SheetData)()
                For Each item As ListViewItem In lstvData.Items
                    Dim row As New Row()
                    For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                        Dim cell As New Cell With {
                        .DataType = CellValues.String,
                        .CellValue = New CellValue(subItem.Text)
                    }
                        row.Append(cell)
                    Next
                    sheetData.Append(row)
                Next

                ' Guardar el documento
                workbook.Workbook.Save()

            End Using

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
