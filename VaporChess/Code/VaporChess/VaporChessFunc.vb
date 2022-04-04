﻿Public Class VaporChessFunc
	'--- V A P O R C H E S S F U N C | GUI references ----------------------------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	Dim LblC1, LblC2, LblC3, LblC4, LblC5, LblC6, LblC7, LblC8 As Label
	Dim LblR1, LblR2, LblR3, LblR4, LblR5, LblR6, LblR7, LblR8 As Label
	'-----------------------------------------------------------------------------------------------------------------------'
	Dim AColumn(ChessBoard.RW.rows) As Panel
	Dim BColumn(ChessBoard.RW.rows) As Panel
	Dim CColumn(ChessBoard.RW.rows) As Panel
	Dim DColumn(ChessBoard.RW.rows) As Panel
	Dim EColumn(ChessBoard.RW.rows) As Panel
	Dim FColumn(ChessBoard.RW.rows) As Panel
	Dim GColumn(ChessBoard.RW.rows) As Panel
	Dim HColumn(ChessBoard.RW.rows) As Panel


	'--- V A P O R C H E S S F U N C | GUI reference functions -------------------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub ColumnsLabelReference(ByRef l1 As Label, ByRef l2 As Label, ByRef l3 As Label, ByRef l4 As Label, ByRef l5 As Label, ByRef l6 As Label, ByRef l7 As Label, ByRef l8 As Label)
		LblC1 = l1
		LblC2 = l2
		LblC3 = l3
		LblC4 = l4
		LblC5 = l5
		LblC6 = l6
		LblC7 = l7
		LblC8 = l8
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub RowsLabelReference(ByRef l1 As Label, ByRef l2 As Label, ByRef l3 As Label, ByRef l4 As Label, ByRef l5 As Label, ByRef l6 As Label, ByRef l7 As Label, ByRef l8 As Label)
		LblR1 = l1
		LblR2 = l2
		LblR3 = l3
		LblR4 = l4
		LblR5 = l5
		LblR6 = l6
		LblR7 = l7
		LblR8 = l8
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceA(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		AColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceB(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		BColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceC(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		CColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceD(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		DColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceE(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		EColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceF(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		FColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceG(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		GColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardColumnsReferenceH(ByRef p1 As Panel, ByRef p2 As Panel, ByRef p3 As Panel, ByRef p4 As Panel, ByRef p5 As Panel, ByRef p6 As Panel, ByRef p7 As Panel, ByRef p8 As Panel)
		HColumn = {p1, p2, p3, p4, p5, p6, p7, p8}
	End Sub


	'--- V A P O R C H E S S F U N C | Public GUI management functions -----------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub CreateBoard(ByRef board(,) As Panel)
		For i = ChessBoard.RW.r1 To ChessBoard.RW.r8
			board(ChessBoard.CL.a, i) = AColumn(i)
			board(ChessBoard.CL.b, i) = BColumn(i)
			board(ChessBoard.CL.c, i) = CColumn(i)
			board(ChessBoard.CL.d, i) = DColumn(i)
			board(ChessBoard.CL.e, i) = EColumn(i)
			board(ChessBoard.CL.f, i) = FColumn(i)
			board(ChessBoard.CL.g, i) = GColumn(i)
			board(ChessBoard.CL.h, i) = HColumn(i)
		Next
		For x = ChessBoard.CL.a To ChessBoard.CL.h
			For y = ChessBoard.RW.r1 To ChessBoard.RW.r8
				If x Mod 2 = 0 Then
					If y Mod 2 = 0 Then
						' Colonna pari, riga pari
						board(x, y).BackColor = ChessBoard.BOARD_COLOUR_DARK
					Else
						' Colonna pari, riga dispari
						board(x, y).BackColor = ChessBoard.BOARD_COLOUR_LIGHT
					End If
				Else
					If y Mod 2 = 0 Then
						' Colonna pari, riga pari
						board(x, y).BackColor = ChessBoard.BOARD_COLOUR_LIGHT
					Else
						' Colonna pari, riga dispari
						board(x, y).BackColor = ChessBoard.BOARD_COLOUR_DARK
					End If
				End If
			Next
		Next
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub PlacePieces(ByRef board(,) As Panel, ByRef pieces As PiecesList)
		' PAWS: place white paws
		For i = ChessBoard.CL.a To ChessBoard.CL.h
			Dim PawsW As New ChessPieces With {
				.Alive = True,
				.First = True,
				.Color = ChessPieces.Colors.White,
				.Type = ChessPieces.Types.Pawn,
				.Position = board(i, ChessBoard.RW.r2)
			}
			PawsW.Position.BackgroundImage = ChessBoard.WPAWN
			pieces.Items.Add(PawsW)
		Next
		' PAWS: place black paws
		For i = ChessBoard.CL.a To ChessBoard.CL.h
			Dim PawsB As New ChessPieces With {
				.Alive = True,
				.First = True,
				.Color = ChessPieces.Colors.Black,
				.Type = ChessPieces.Types.Pawn,
				.Position = board(i, ChessBoard.RW.r7)
			}
			PawsB.Position.BackgroundImage = ChessBoard.BPAWN
			pieces.Items.Add(PawsB)
		Next
		' KNIGHTS: place white knights
		Dim Knight1W As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.Knight,
			.Position = board(ChessBoard.CL.b, ChessBoard.RW.r1)
		}
		Dim Knight2W As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.Knight,
			.Position = board(ChessBoard.CL.g, ChessBoard.RW.r1)
		}
		Knight1W.Position.BackgroundImage = ChessBoard.WKNIGHT
		Knight2W.Position.BackgroundImage = ChessBoard.WKNIGHT
		pieces.Items.Add(Knight1W)
		pieces.Items.Add(Knight2W)
		' KNIGHTS: place black knights
		Dim Knight1B As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.Knight,
			.Position = board(ChessBoard.CL.b, ChessBoard.RW.r8)
		}
		Dim Knight2B As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.Knight,
			.Position = board(ChessBoard.CL.g, ChessBoard.RW.r8)
		}
		Knight1B.Position.BackgroundImage = ChessBoard.BKNIGHT
		Knight2B.Position.BackgroundImage = ChessBoard.BKNIGHT
		pieces.Items.Add(Knight1B)
		pieces.Items.Add(Knight2B)
		' BISHOPS: place white bishops
		Dim Bishop1W As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.Bishop,
			.Position = board(ChessBoard.CL.c, ChessBoard.RW.r1)
		}
		Dim Bishop2W As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.Bishop,
			.Position = board(ChessBoard.CL.f, ChessBoard.RW.r1)
		}
		Bishop1W.Position.BackgroundImage = ChessBoard.WBISHOP
		Bishop2W.Position.BackgroundImage = ChessBoard.WBISHOP
		pieces.Items.Add(Bishop1W)
		pieces.Items.Add(Bishop2W)
		' BISHOPS: place black bishops
		Dim Bishop1B As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.Bishop,
			.Position = board(ChessBoard.CL.c, ChessBoard.RW.r8)
		}
		Dim Bishop2B As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.Bishop,
			.Position = board(ChessBoard.CL.f, ChessBoard.RW.r8)
		}
		Bishop1B.Position.BackgroundImage = ChessBoard.BBISHOP
		Bishop2B.Position.BackgroundImage = ChessBoard.BBISHOP
		pieces.Items.Add(Bishop1B)
		pieces.Items.Add(Bishop2B)
		' ROOKS: place white rooks
		Dim Rook1W As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.Rook,
			.Position = board(ChessBoard.CL.a, ChessBoard.RW.r1)
		}
		Dim Rook2W As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.Rook,
			.Position = board(ChessBoard.CL.h, ChessBoard.RW.r1)
		}
		Rook1W.Position.BackgroundImage = ChessBoard.WROOK
		Rook2W.Position.BackgroundImage = ChessBoard.WROOK
		pieces.Items.Add(Rook1W)
		pieces.Items.Add(Rook2W)
		' ROOKS: place black rooks
		Dim Rook1B As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.Rook,
			.Position = board(ChessBoard.CL.a, ChessBoard.RW.r8)
		}
		Dim Rook2B As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.Rook,
			.Position = board(ChessBoard.CL.h, ChessBoard.RW.r8)
		}
		Rook1B.Position.BackgroundImage = ChessBoard.BROOK
		Rook2B.Position.BackgroundImage = ChessBoard.BROOK
		pieces.Items.Add(Rook1B)
		pieces.Items.Add(Rook2B)
		' QUEEN: place white queen
		Dim QueenW As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.Queen,
			.Position = board(ChessBoard.CL.d, ChessBoard.RW.r1)
		}
		QueenW.Position.BackgroundImage = ChessBoard.WQUEEN
		pieces.Items.Add(QueenW)
		' QUEEN: place black queen
		Dim QueenB As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.Queen,
			.Position = board(ChessBoard.CL.d, ChessBoard.RW.r8)
		}
		QueenB.Position.BackgroundImage = ChessBoard.BQUEEN
		pieces.Items.Add(QueenB)
		' KING: place white king
		Dim KingW As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.White,
			.Type = ChessPieces.Types.King,
			.Position = board(ChessBoard.CL.e, ChessBoard.RW.r1)
		}
		KingW.Position.BackgroundImage = ChessBoard.WKING
		pieces.Items.Add(KingW)
		' KING: place black king
		Dim KingB As New ChessPieces With {
			.Alive = True,
			.First = True,
			.Color = ChessPieces.Colors.Black,
			.Type = ChessPieces.Types.King,
			.Position = board(ChessBoard.CL.e, ChessBoard.RW.r8)
		}
		KingB.Position.BackgroundImage = ChessBoard.BKING
		pieces.Items.Add(KingB)
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub RotateBoard(ByVal playblack As Boolean)
		If playblack = False Then
			For i = ChessBoard.RW.r1 To ChessBoard.RW.r8
				AColumn(i).Location = New Point(54 * ChessBoard.CL.a, i * 54)
				BColumn(i).Location = New Point(54 * ChessBoard.CL.b, i * 54)
				CColumn(i).Location = New Point(54 * ChessBoard.CL.c, i * 54)
				DColumn(i).Location = New Point(54 * ChessBoard.CL.d, i * 54)
				EColumn(i).Location = New Point(54 * ChessBoard.CL.e, i * 54)
				FColumn(i).Location = New Point(54 * ChessBoard.CL.f, i * 54)
				GColumn(i).Location = New Point(54 * ChessBoard.CL.g, i * 54)
				HColumn(i).Location = New Point(54 * ChessBoard.CL.h, i * 54)
			Next
			LblC1.Text = "   a"
			LblC2.Text = "   b"
			LblC3.Text = "   c"
			LblC4.Text = "   d"
			LblC5.Text = "   e"
			LblC6.Text = "   f"
			LblC7.Text = "   g"
			LblC8.Text = "   h"
			LblR1.Text = "1"
			LblR2.Text = "2"
			LblR3.Text = "3"
			LblR4.Text = "4"
			LblR5.Text = "5"
			LblR6.Text = "6"
			LblR7.Text = "7"
			LblR8.Text = "8"
		Else
			For i = ChessBoard.RW.r1 To ChessBoard.RW.r8
				AColumn(i).Location = New Point(54 * ChessBoard.CL.h, i * 54)
				BColumn(i).Location = New Point(54 * ChessBoard.CL.g, i * 54)
				CColumn(i).Location = New Point(54 * ChessBoard.CL.f, i * 54)
				DColumn(i).Location = New Point(54 * ChessBoard.CL.e, i * 54)
				EColumn(i).Location = New Point(54 * ChessBoard.CL.d, i * 54)
				FColumn(i).Location = New Point(54 * ChessBoard.CL.c, i * 54)
				GColumn(i).Location = New Point(54 * ChessBoard.CL.b, i * 54)
				HColumn(i).Location = New Point(54 * ChessBoard.CL.a, i * 54)
			Next
			LblC1.Text = "   h"
			LblC2.Text = "   g"
			LblC3.Text = "   f"
			LblC4.Text = "   e"
			LblC5.Text = "   d"
			LblC6.Text = "   c"
			LblC7.Text = "   b"
			LblC8.Text = "   a"
			LblR1.Text = "8"
			LblR2.Text = "7"
			LblR3.Text = "6"
			LblR4.Text = "5"
			LblR5.Text = "4"
			LblR6.Text = "3"
			LblR7.Text = "2"
			LblR8.Text = "1"
		End If
	End Sub


	'--- V A P O R C H E S S F U N C | Private GUI management functions ----------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	'Private Sub ShowMoveSet(ByRef moveset As List(Of Panel), ByRef movesetcolor As List(Of Color), ByRef board(,) As Panel, ByRef piece As PiecesList, ByVal indexer As Byte)
	Private Sub ShowMoveSet(ByRef movesetcolor As List(Of Color), ByRef board(,) As Panel, ByRef piece As PiecesList, ByVal indexer As Byte)
		Dim adder As New List(Of Point)
		Dim juice As Byte

		piece.Items(indexer).LegalMoves.Clear()

		Select Case piece.Items(indexer).Type
			Case ChessPieces.Types.Pawn
				For Each move As Point In ChessPieces.PawnMoves
					Dim X = piece.Items(indexer).Column + move.X
					Dim Y = piece.Items(indexer).Row + move.Y
					If Y < ChessBoard.RW.rows And Y >= 0 And X >= 0 And X < ChessBoard.CL.columns Then
						If IfPresentGetPiece(piece, board(X, Y), juice) Then
							If Juicer(piece, board(X, Y), indexer, juice) Then
								If move.X <> 0 And ((move.Y > 0 And piece.Items(indexer).Color = ChessPieces.Colors.White) Or (move.Y < 0 And piece.Items(indexer).Color = ChessPieces.Colors.Black)) Then
									piece.Items(indexer).LegalMoves.Add(board(X, Y))
								End If
							End If
						Else
							If move.X = 0 And ((move.Y > 0 And piece.Items(indexer).Color = ChessPieces.Colors.White) Or (move.Y < 0 And piece.Items(indexer).Color = ChessPieces.Colors.Black)) Then
								piece.Items(indexer).LegalMoves.Add(board(X, Y))
								If Math.Abs(move.Y) > 1 And piece.Items(indexer).First = False Then
									piece.Items(indexer).LegalMoves.Remove(board(X, Y))
								End If
							End If
						End If
					End If
				Next

			Case ChessPieces.Types.King
				For Each move As Point In ChessPieces.KingMoves
					Dim X = piece.Items(indexer).Column + move.X
					Dim Y = piece.Items(indexer).Row + move.Y
					If Y < ChessBoard.RW.rows And Y >= 0 And X >= 0 And X < ChessBoard.CL.columns Then
						If IfPresentGetPiece(piece, board(X, Y), juice) Then
							If Juicer(piece, board(X, Y), indexer, juice) Then
								piece.Items(indexer).LegalMoves.Add(board(X, Y))
							End If
						Else
							piece.Items(indexer).LegalMoves.Add(board(X, Y))
						End If
					End If
				Next

			Case ChessPieces.Types.Knight
				For Each move As Point In ChessPieces.KnightMoves
					Dim X = piece.Items(indexer).Column + move.X
					Dim Y = piece.Items(indexer).Row + move.Y
					If Y < ChessBoard.RW.rows And Y >= 0 And X >= 0 And X < ChessBoard.CL.columns Then
						If IfPresentGetPiece(piece, board(X, Y), juice) Then
							If Juicer(piece, board(X, Y), indexer, juice) Then
								piece.Items(indexer).LegalMoves.Add(board(X, Y))
							End If
						Else
							piece.Items(indexer).LegalMoves.Add(board(X, Y))
						End If
					End If
				Next

			Case ChessPieces.Types.Rook
				Dim LockUp As New Point With {
					.X = ChessBoard.CL.columns,
					.Y = ChessBoard.RW.rows
				}
				Dim LockDown As New Point With {
					.X = 0,
					.Y = 0
				}
				For Each move As Point In ChessPieces.RookMoves
					Dim X = piece.Items(indexer).Column + move.X
					Dim Y = piece.Items(indexer).Row + move.Y
					If Y < ChessBoard.RW.rows And Y >= 0 And X >= 0 And X < ChessBoard.CL.columns Then
						If IfPresentGetPiece(piece, board(X, Y), juice) Then
							If (X = piece.Items(indexer).Column Or Y = piece.Items(indexer).Row) And (X <= LockUp.X And Y <= LockUp.Y) And (X >= LockDown.X And Y >= LockDown.Y) Then
								If Juicer(piece, board(piece.Items(indexer).Column + move.X, piece.Items(indexer).Row + move.Y), indexer, juice) Then
									piece.Items(indexer).LegalMoves.Add(board(piece.Items(indexer).Column + move.X, piece.Items(indexer).Row + move.Y))
								End If
							End If
							If X = piece.Items(indexer).Column Then
								If LockUp.Y = ChessBoard.RW.rows And Y > piece.Items(indexer).Row Then
									LockUp.Y = Y
								ElseIf LockDown.Y = 0 And Y < piece.Items(indexer).Row Then
									LockDown.Y = Y
								End If
							End If
							If Y = piece.Items(indexer).Row Then
								If LockUp.X = ChessBoard.CL.columns And X > piece.Items(indexer).Column Then
									LockUp.X = X
								ElseIf LockDown.X = 0 And X < piece.Items(indexer).Column Then
									LockDown.X = X
								End If
							End If
						Else
							If (X = piece.Items(indexer).Column Or Y = piece.Items(indexer).Row) And (X <= LockUp.X And Y <= LockUp.Y) And (X >= LockDown.X And Y >= LockDown.Y) Then
								piece.Items(indexer).LegalMoves.Add(board(X, Y))
							End If
						End If
					End If
				Next

			Case ChessPieces.Types.Bishop
				Dim LockUpRx As New Point With {
					.X = ChessBoard.CL.columns,
					.Y = ChessBoard.RW.rows
				}
				Dim LockDownRx As New Point With {
					.X = ChessBoard.CL.columns,
					.Y = 0
				}
				Dim LockUpSx As New Point With {
					.X = 0,
					.Y = ChessBoard.RW.rows
				}
				Dim LockDownSx As New Point With {
					.X = 0,
					.Y = 0
				}
				For Each move As Point In ChessPieces.BishopMoves
					Dim X = piece.Items(indexer).Column + move.X
					Dim Y = piece.Items(indexer).Row + move.Y
					If Y < ChessBoard.RW.rows And Y >= 0 And X >= 0 And X < ChessBoard.CL.columns Then
						If IfPresentGetPiece(piece, board(X, Y), juice) Then
							If (X > piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X <= LockUpRx.X And Y <= LockUpRx.Y) Or
								(X < piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X >= LockUpSx.X And Y <= LockUpSx.Y) Or
								(X > piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X <= LockDownRx.X And Y >= LockDownRx.Y) Or
								(X < piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X >= LockDownSx.X And Y >= LockDownSx.Y) Then
								If Juicer(piece, board(piece.Items(indexer).Column + move.X, piece.Items(indexer).Row + move.Y), indexer, juice) Then
									piece.Items(indexer).LegalMoves.Add(board(piece.Items(indexer).Column + move.X, piece.Items(indexer).Row + move.Y))
								End If
							End If
							' Limite ALTO-DX
							If (LockUpRx.X = ChessBoard.CL.columns And LockUpRx.Y = ChessBoard.RW.rows) And (X > piece.Items(indexer).Column And Y > piece.Items(indexer).Row) Then
								LockUpRx.X = X
								LockUpRx.Y = Y
							End If
							' Limite ALTO-SX
							If (LockUpSx.X = 0 And LockUpSx.Y = ChessBoard.RW.rows) And (X < piece.Items(indexer).Column And Y > piece.Items(indexer).Row) Then
								LockUpSx.X = X
								LockUpSx.Y = Y
							End If
							' Limite BASSO-DX
							If (LockDownRx.X = ChessBoard.CL.columns And LockDownRx.Y = 0) And (X > piece.Items(indexer).Column And Y < piece.Items(indexer).Row) Then
								LockDownRx.X = X
								LockDownRx.Y = Y
							End If
							' Limite BASSO-SX
							If (LockDownSx.X = 0 And LockDownSx.Y = 0) And (X < piece.Items(indexer).Column And Y < piece.Items(indexer).Row) Then
								LockDownSx.X = X
								LockDownSx.Y = Y
							End If
						Else
							If (X > piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X <= LockUpRx.X And Y <= LockUpRx.Y) Or
								(X < piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X >= LockUpSx.X And Y <= LockUpSx.Y) Or
								(X > piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X <= LockDownRx.X And Y >= LockDownRx.Y) Or
								(X < piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X >= LockDownSx.X And Y >= LockDownSx.Y) Then
								piece.Items(indexer).LegalMoves.Add(board(X, Y))
							End If
						End If
					End If
				Next

			Case ChessPieces.Types.Queen
				Dim LockUp As New Point With {
					.X = ChessBoard.CL.columns,
					.Y = ChessBoard.RW.rows
				}
				Dim LockDown As New Point With {
					.X = 0,
					.Y = 0
				}
				Dim LockUpRx As New Point With {
					.X = ChessBoard.CL.columns,
					.Y = ChessBoard.RW.rows
				}
				Dim LockDownRx As New Point With {
					.X = ChessBoard.CL.columns,
					.Y = 0
				}
				Dim LockUpSx As New Point With {
					.X = 0,
					.Y = ChessBoard.RW.rows
				}
				Dim LockDownSx As New Point With {
					.X = 0,
					.Y = 0
				}
				For Each move As Point In ChessPieces.QueenMoves
					Dim X = piece.Items(indexer).Column + move.X
					Dim Y = piece.Items(indexer).Row + move.Y
					If Y < ChessBoard.RW.rows And Y >= 0 And X >= 0 And X < ChessBoard.CL.columns Then
						If IfPresentGetPiece(piece, board(X, Y), juice) Then
							If (X <= LockUp.X And Y <= LockUp.Y) And (X >= LockDown.X And Y >= LockDown.Y) Or
								(X > piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X <= LockUpRx.X And Y <= LockUpRx.Y) Or
								(X < piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X >= LockUpSx.X And Y <= LockUpSx.Y) Or
								(X > piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X <= LockDownRx.X And Y >= LockDownRx.Y) Or
								(X < piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X >= LockDownSx.X And Y >= LockDownSx.Y) Then
								If Juicer(piece, board(piece.Items(indexer).Column + move.X, piece.Items(indexer).Row + move.Y), indexer, juice) Then
									piece.Items(indexer).LegalMoves.Add(board(piece.Items(indexer).Column + move.X, piece.Items(indexer).Row + move.Y))
								End If
							End If
							' Limite VERTICALE
							If X = piece.Items(indexer).Column Then
								If LockUp.Y = ChessBoard.RW.rows And Y > piece.Items(indexer).Row Then
									LockUp.Y = Y
								ElseIf LockDown.Y = 0 And Y < piece.Items(indexer).Row Then
									LockDown.Y = Y
								End If
							End If
							' Limite ORIZZONTALE
							If Y = piece.Items(indexer).Row Then
								If LockUp.X = ChessBoard.CL.columns And X > piece.Items(indexer).Column Then
									LockUp.X = X
								ElseIf LockDown.X = 0 And X < piece.Items(indexer).Column Then
									LockDown.X = X
								End If
							End If
							' Limite ALTO-DX
							If (LockUpRx.X = ChessBoard.CL.columns And LockUpRx.Y = ChessBoard.RW.rows) And (X > piece.Items(indexer).Column And Y > piece.Items(indexer).Row) Then
								LockUpRx.X = X
								LockUpRx.Y = Y
							End If
							' Limite ALTO-SX
							If (LockUpSx.X = 0 And LockUpSx.Y = ChessBoard.RW.rows) And (X < piece.Items(indexer).Column And Y > piece.Items(indexer).Row) Then
								LockUpSx.X = X
								LockUpSx.Y = Y
							End If
							' Limite BASSO-DX
							If (LockDownRx.X = ChessBoard.CL.columns And LockDownRx.Y = 0) And (X > piece.Items(indexer).Column And Y < piece.Items(indexer).Row) Then
								LockDownRx.X = X
								LockDownRx.Y = Y
							End If
							' Limite BASSO-SX
							If (LockDownSx.X = 0 And LockDownSx.Y = 0) And (X < piece.Items(indexer).Column And Y < piece.Items(indexer).Row) Then
								LockDownSx.X = X
								LockDownSx.Y = Y
							End If
						Else
							If ((X = piece.Items(indexer).Column Or Y = piece.Items(indexer).Row) And (X <= LockUp.X And Y <= LockUp.Y) And (X >= LockDown.X And Y >= LockDown.Y)) Or
								(X > piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X <= LockUpRx.X And Y <= LockUpRx.Y) Or
								(X < piece.Items(indexer).Column And Y > piece.Items(indexer).Row) And (X >= LockUpSx.X And Y <= LockUpSx.Y) Or
								(X > piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X <= LockDownRx.X And Y >= LockDownRx.Y) Or
								(X < piece.Items(indexer).Column And Y < piece.Items(indexer).Row) And (X >= LockDownSx.X And Y >= LockDownSx.Y) Then
								piece.Items(indexer).LegalMoves.Add(board(X, Y))
							End If
						End If
					End If
				Next

		End Select

		For Each panel As Panel In piece.Items(indexer).LegalMoves
			movesetcolor.Add(panel.BackColor)
			panel.BackColor = Color.Turquoise
		Next
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub CLearMoveSet(ByRef moveset As List(Of Panel), ByRef movesetcolor As List(Of Color))
		For i = 0 To moveset.Count - 1
			moveset(i).BackColor = movesetcolor(i)
		Next
		moveset.Clear()
		movesetcolor.Clear()
	End Sub


	'--- V A P O R C H E S S F U N C | Public Board management functions ---------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Sub BoardClick(ByRef clicked As Panel, ByRef board(,) As Panel, ByRef pieces As PiecesList)
		Static ClickOn As Boolean = False
		Static MovingIndex As Byte
		Static CapturedIndex As Byte
		Static StartPiecePosition As Panel = Nothing
		Static StartBoardColor As Color
		Static MoveSetColor As New List(Of Color)

		If ClickOn = False Then
			' First click: select a piece
			If IfPresentGetPiece(pieces, clicked, MovingIndex) Then
				StartPiecePosition = clicked
				StartBoardColor = StartPiecePosition.BackColor
				clicked.BackColor = Color.Teal
				ClickOn = True
				GetBoardCoordinates(pieces, board, MovingIndex)
				ShowMoveSet(MoveSetColor, board, pieces, MovingIndex)
			End If
		Else
			' Second click: move a piece
			StartPiecePosition.BackColor = StartBoardColor
			If clicked IsNot StartPiecePosition Then
				' Confirm move
				If IsMoveValid(board, pieces.Items(MovingIndex).LegalMoves, clicked) Then
					If IfPresentGetPiece(pieces, clicked, CapturedIndex) Then
						GetBoardCoordinates(pieces, board, CapturedIndex)
						If pieces.Items(MovingIndex).Color = pieces.Items(CapturedIndex).Color Then
							' Cannot auto-capture pieces
						Else
							' Capture a piece
							CapturePiece(pieces, CapturedIndex)
							MovePiece(pieces, clicked, MovingIndex)
						End If
					Else
						MovePiece(pieces, clicked, MovingIndex)
					End If
				End If
			End If
			ClickOn = False
			CLearMoveSet(pieces.Items(MovingIndex).LegalMoves, MoveSetColor)
		End If
	End Sub


	'--- V A P O R C H E S S F U N C | Private Board management functions --------------------------------------------------'
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Function IsMoveValid(ByRef board(,) As Panel, ByRef moveset As List(Of Panel), ByVal clicked As Panel) As Boolean
		Return moveset.Contains(clicked)
	End Function
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Function IfPresentGetPiece(ByRef origin As PiecesList, ByRef position As Panel, ByRef indexer As Byte) As Boolean
		Dim i As Byte = 0
		For Each piece As ChessPieces In origin.Items
			If position Is piece.Position Then
				If piece.Alive Then
					indexer = i
					Return True
				Else
					i += 1
				End If
			Else
				i += 1
			End If
		Next
		Return False
	End Function
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Function Juicer(ByRef origin As PiecesList, ByRef position As Panel, ByRef indexer As Byte, ByRef juice As Byte) As Boolean
		If IfPresentGetPiece(origin, position, juice) Then
			If origin.Items(juice).Color <> origin.Items(indexer).Color Then
				Return True
			End If
		End If
		Return False
	End Function
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub GetBoardCoordinates(ByRef origin As PiecesList, ByRef board(,) As Panel, ByVal indexer As Byte)
		For x = 0 To ChessBoard.CL.columns - 1
			For y = 0 To ChessBoard.RW.rows - 1
				If board(x, y) Is origin.Items(indexer).Position Then
					origin.Items(indexer).Column = x
					origin.Items(indexer).Row = y
					Exit For
				End If
			Next
		Next
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub MovePiece(ByRef origin As PiecesList, ByRef dest As Panel, ByVal indexer As Byte)
		origin.Items(indexer).First = False
		dest.BackgroundImage = origin.Items(indexer).Position.BackgroundImage
		origin.Items(indexer).Position.BackgroundImage = Nothing
		origin.Items(indexer).Position = dest
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub CapturePiece(ByRef origin As PiecesList, ByVal indexer As Byte)
		origin.Items(indexer).Color = ChessPieces.Colors.None
		origin.Items(indexer).Alive = False
		origin.Items(indexer).Type = ChessPieces.Types.NofTypes
		origin.Items(indexer).Column = ChessBoard.CL.columns
		origin.Items(indexer).Row = ChessBoard.RW.rows
	End Sub
End Class
