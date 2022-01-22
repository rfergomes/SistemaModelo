Imports FontAwesome.Sharp
Public Class FrmPrincipal
    'Campos
    Private currentBtn As IconButton
    Private ReadOnly leftBorderBtn As Panel
    'Construtor
    Public Sub New()
        'Chamada requerida para o designer
        InitializeComponent()
        'Adiciona qualquer inicialização após a chamada InitializeComponent().
        leftBorderBtn = New Panel With {
            .Size = New Size(7, 60)
        }
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            With currentBtn
                '.BackColor = Color.FromArgb(52, 58, 64)
                .ForeColor = customColor
                .IconColor = customColor
                .TextAlign = ContentAlignment.MiddleCenter
                .ImageAlign = ContentAlignment.MiddleRight
                .TextImageRelation = TextImageRelation.TextBeforeImage
            End With
            'Left Border
            With leftBorderBtn
                .BackColor = customColor
                .Location = New Point(0, currentBtn.Location.Y)
                .Visible = True
                .BringToFront()
            End With
            IconTitulo.IconChar = currentBtn.IconChar
            IconTitulo.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            With currentBtn
                '.BackColor = Color.FromArgb(52, 58, 64)
                .ForeColor = Color.Gainsboro
                .IconColor = Color.Gainsboro
                .TextAlign = ContentAlignment.MiddleLeft
                .ImageAlign = ContentAlignment.MiddleLeft
                .TextImageRelation = TextImageRelation.ImageBeforeText
            End With
        End If
    End Sub
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActiveButton(sender, RGBColors.Cor1)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActiveButton(sender, RGBColors.Cor2)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActiveButton(sender, RGBColors.Cor3)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActiveButton(sender, RGBColors.Cor4)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Application.Exit()
    End Sub
End Class