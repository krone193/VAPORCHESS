Imports System.ComponentModel

Public Class Chess
	'--- V A P O R C H E S S | Namespace declarations ----------------------------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	ReadOnly ChessFunc As New VaporChessFunc


	'--- V A P O R C H E S S | Declarations --------------------------------------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	ReadOnly SavedGamePath As String = "last.dream"
	ReadOnly Board(ChessBoard.CL.columns, ChessBoard.RW.rows) As Panel
	ReadOnly Pieces As New PiecesList


	'--- V A P O R C H E S S | Variables -----------------------------------------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Structure UserSettings
		Dim MyName As String
		Dim ThyName As String
	End Structure
	Public Settings As UserSettings

	Sub ArgumentStringCleaner(ByRef toclean As String)
		If toclean.First() = ControlChars.Quote Then
			toclean = toclean.Substring(1)
		End If
		If toclean.Last() = ControlChars.Quote Then
			toclean = toclean.Substring(0, toclean.Length - 1)
		End If
	End Sub

	'--- V A P O R C H E S S | GUI functions -------------------------------------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub Chess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CheckForIllegalCrossThreadCalls = False
		Me.Text = "【﻿ ｖ ａ ｐ ｏ ｒ ｃ ｈ ｅ ｓ ｓ 】【﻿" & My.Application.Info.Version.ToString() & "】"
		ChessFunc.ColumnsLabelReference(LblC1, LblC2, LblC3, LblC4, LblC5, LblC6, LblC7, LblC8)
		ChessFunc.RowsLabelReference(LblR1, LblR2, LblR3, LblR4, LblR5, LblR6, LblR7, LblR8)
		ChessFunc.BoardColumnsReferenceA(a1, a2, a3, a4, a5, a6, a7, a8)
		ChessFunc.BoardColumnsReferenceB(b1, b2, b3, b4, b5, b6, b7, b8)
		ChessFunc.BoardColumnsReferenceC(c1, c2, c3, c4, c5, c6, c7, c8)
		ChessFunc.BoardColumnsReferenceD(d1, d2, d3, d4, d5, d6, d7, d8)
		ChessFunc.BoardColumnsReferenceE(e1, e2, e3, e4, e5, e6, e7, e8)
		ChessFunc.BoardColumnsReferenceF(f1, f2, f3, f4, f5, f6, f7, f8)
		ChessFunc.BoardColumnsReferenceG(g1, g2, g3, g4, g5, g6, g7, g8)
		ChessFunc.BoardColumnsReferenceH(h1, h2, h3, h4, h5, h6, h7, h8)
		ChessFunc.CreateBoard(Board)
		ChessFunc.PlacePieces(Board, Pieces)
		If IO.File.Exists(SavedGamePath) Then
			' Load previous game
		Else
			Settings.MyName = "it's a me"
			Settings.ThyName = "a boi"
			' Start a new game with passed parameters
			If My.Application.CommandLineArgs.Count > 0 Then
				If My.Application.CommandLineArgs.ElementAt(0) <> "" Then
					Settings.MyName = My.Application.CommandLineArgs.ElementAt(0)
					ArgumentStringCleaner(Settings.MyName)
					If My.Application.CommandLineArgs.Count > 1 Then
						If My.Application.CommandLineArgs.ElementAt(1) <> "" Then
							Settings.ThyName = My.Application.CommandLineArgs.ElementAt(1)
							ArgumentStringCleaner(Settings.ThyName)
						End If
					End If
				End If
			End If
		End If
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub Chess_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dim result As DialogResult = MessageBox.Show("Do you want to save the game?", "V A P O R C H E S S - Warning message", MessageBoxButtons.YesNoCancel)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		ElseIf result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
			'SaveSettings()
		End If
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub Chess_MouseClick(sender As Object, e As MouseEventArgs) Handles a1.MouseClick, a2.MouseClick, a3.MouseClick, a4.MouseClick, a5.MouseClick, a6.MouseClick, a7.MouseClick, a8.MouseClick,
		b1.MouseClick, b2.MouseClick, b3.MouseClick, b4.MouseClick, b5.MouseClick, b6.MouseClick, b7.MouseClick, b8.MouseClick,
		c1.MouseClick, c2.MouseClick, c3.MouseClick, c4.MouseClick, c5.MouseClick, c6.MouseClick, c7.MouseClick, c8.MouseClick,
		d1.MouseClick, d2.MouseClick, d3.MouseClick, d4.MouseClick, d5.MouseClick, d6.MouseClick, d7.MouseClick, d8.MouseClick,
		e1.MouseClick, e2.MouseClick, e3.MouseClick, e4.MouseClick, e5.MouseClick, e6.MouseClick, e7.MouseClick, e8.MouseClick,
		f1.MouseClick, f2.MouseClick, f3.MouseClick, f4.MouseClick, f5.MouseClick, f6.MouseClick, f7.MouseClick, f8.MouseClick,
		g1.MouseClick, g2.MouseClick, g3.MouseClick, g4.MouseClick, g5.MouseClick, g6.MouseClick, g7.MouseClick, g8.MouseClick,
		h1.MouseClick, h2.MouseClick, h3.MouseClick, h4.MouseClick, h5.MouseClick, h6.MouseClick, h7.MouseClick, h8.MouseClick

		If e.Button = MouseButtons.Left Then
			ChessFunc.BoardClick(sender, Board, Pieces)
		End If
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub ChbPlayAsBlack_Click(sender As Object, e As EventArgs) Handles ChbPlayAsBlack.Click
		ChessFunc.RotateBoard(True)
		ChbPlayAsBlack.Enabled = False
	End Sub

End Class