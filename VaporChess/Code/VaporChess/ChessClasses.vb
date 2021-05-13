﻿'-------------------------------------------------------------------------------------------------------------------------'
'------------------------------------------------- C H E S S   B O A R D -------------------------------------------------'
'-------------------------------------------------------------------------------------------------------------------------'
Public Class ChessBoard
	'-----------------------------------------------------------------------------------------------------------------------'
	'--- C H E S S B O A R D | Public Shared ReadOnly ----------------------------------------------------------------------'
	Public Shared ReadOnly BOARD_COLOUR_LIGHT As Color = Color.LavenderBlush
	Public Shared ReadOnly BOARD_COLOUR_DARK As Color = Color.PaleVioletRed
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Shared ReadOnly WPAWN As Image = My.Resources.wPawn
	Public Shared ReadOnly WBISHOP As Image = My.Resources.wBishop
	Public Shared ReadOnly WKNIGHT As Image = My.Resources.wKnight
	Public Shared ReadOnly WROOK As Image = My.Resources.wRook
	Public Shared ReadOnly WQUEEN As Image = My.Resources.wQueen
	Public Shared ReadOnly WKING As Image = My.Resources.wKing
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Shared ReadOnly BPAWN As Image = My.Resources.bPawn
	Public Shared ReadOnly BBISHOP As Image = My.Resources.bBishop
	Public Shared ReadOnly BKNIGHT As Image = My.Resources.bKnight
	Public Shared ReadOnly BROOK As Image = My.Resources.bRook
	Public Shared ReadOnly BQUEEN As Image = My.Resources.bQueen
	Public Shared ReadOnly BKING As Image = My.Resources.bKing
	'-----------------------------------------------------------------------------------------------------------------------'
	'--- C H E S S B O A R D | Public Enums --------------------------------------------------------------------------------'
	Public Enum CL
		a
		b
		c
		d
		e
		f
		g
		h
		columns
	End Enum
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Enum RW
		r1
		r2
		r3
		r4
		r5
		r6
		r7
		r8
		rows
	End Enum
End Class



'-------------------------------------------------------------------------------------------------------------------------'
'------------------------------------------------ C H E S S   P I E C E S ------------------------------------------------'
'-------------------------------------------------------------------------------------------------------------------------'
Public Class ChessPieces
	'-----------------------------------------------------------------------------------------------------------------------'
	'--- C H E S S P I E C E S | Public Enums ------------------------------------------------------------------------------'
	Public Enum Types
		Pawn
		Bishop
		Knight
		Rook
		Queen
		King
		NofTypes
	End Enum
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Enum Colors
		White
		Black
		None
	End Enum
	'-----------------------------------------------------------------------------------------------------------------------'
	'--- C H E S S P I E C E S | Pieces move sets --------------------------------------------------------------------------'
	Public Shared PawnMoves As New List(Of Point) From {
			New Point(0, 1),
			New Point(0, 2),
			New Point(1, 1),
			New Point(-1, 1),
			New Point(0, -1),
			New Point(0, -2),
			New Point(1, -1),
			New Point(-1, -1)
		}
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Shared KnightMoves As New List(Of Point) From {
		New Point(1, 2),
		New Point(1, -2),
		New Point(-1, 2),
		New Point(-1, -2),
		New Point(2, 1),
		New Point(2, -1),
		New Point(-2, +1),
		New Point(-2, -1)
	}
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Shared BishopMoves As New List(Of Point) From {
		New Point(1, 1), New Point(2, 2), New Point(3, 3), New Point(4, 4), New Point(5, 5), New Point(6, 6), New Point(7, 7),
		New Point(-1, 1), New Point(-2, 2), New Point(-3, 3), New Point(-4, 4), New Point(-5, 5), New Point(-6, 6), New Point(-7, 7),
		New Point(1, -1), New Point(2, -2), New Point(3, -3), New Point(4, -4), New Point(5, -5), New Point(6, -6), New Point(7, -7),
		New Point(-1, -1), New Point(-2, -2), New Point(-3, -3), New Point(-4, -4), New Point(-5, -5), New Point(-6, -6), New Point(-7, -7)
	}
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Shared RookMoves As New List(Of Point) From {
		New Point(0, 1), New Point(0, 2), New Point(0, 3), New Point(0, 4), New Point(0, 5), New Point(0, 6), New Point(0, 7),
		New Point(0, -1), New Point(0, -2), New Point(0, -3), New Point(0, -4), New Point(0, -5), New Point(0, -6), New Point(0, -7),
		New Point(1, 0), New Point(2, 0), New Point(3, 0), New Point(4, 0), New Point(5, 0), New Point(6, 0), New Point(7, 0),
		New Point(-1, 0), New Point(-2, 0), New Point(-3, 0), New Point(-4, 0), New Point(-5, 0), New Point(-6, 0), New Point(-7, 0)
	}
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Shared QueenMoves As New List(Of Point) From {
		New Point(0, 1), New Point(0, 2), New Point(0, 3), New Point(0, 4), New Point(0, 5), New Point(0, 6), New Point(0, 7),
		New Point(0, -1), New Point(0, -2), New Point(0, -3), New Point(0, -4), New Point(0, -5), New Point(0, -6), New Point(0, -7),
		New Point(1, 0), New Point(2, 0), New Point(3, 0), New Point(4, 0), New Point(5, 0), New Point(6, 0), New Point(7, 0),
		New Point(-1, 0), New Point(-2, 0), New Point(-3, 0), New Point(-4, 0), New Point(-5, 0), New Point(-6, 0), New Point(-7, 0),
		New Point(1, 1), New Point(2, 2), New Point(3, 3), New Point(4, 4), New Point(5, 5), New Point(6, 6), New Point(7, 7),
		New Point(-1, 1), New Point(-2, 2), New Point(-3, 3), New Point(-4, 4), New Point(-5, 5), New Point(-6, 6), New Point(-7, 7),
		New Point(1, -1), New Point(2, -2), New Point(3, -3), New Point(4, -4), New Point(5, -5), New Point(6, -6), New Point(7, -7),
		New Point(-1, -1), New Point(-2, -2), New Point(-3, -3), New Point(-4, -4), New Point(-5, -5), New Point(-6, -6), New Point(-7, -7)
	}
	'-----------------------------------------------------------------------------------------------------------------------'
	Public Shared KingMoves As New List(Of Point) From {
		New Point(1, 0),
		New Point(-1, 0),
		New Point(-1, 1),
		New Point(1, 1),
		New Point(0, 1),
		New Point(0, -1),
		New Point(1, -1),
		New Point(-1, -1)
	}
	'-----------------------------------------------------------------------------------------------------------------------'
	'--- C H E S S P I E C E S | Public variables --------------------------------------------------------------------------'
	Public Alive As Boolean
	Public First As Boolean
	Public Color As Colors
	Public Type As Types
	Public Position As Panel
	Public Column As UShort
	Public Row As UShort
End Class



'-------------------------------------------------------------------------------------------------------------------------'
'------------------------------------------------- P I E C E S   L I S T -------------------------------------------------'
'-------------------------------------------------------------------------------------------------------------------------'
Public Class PiecesList
	'-----------------------------------------------------------------------------------------------------------------------'
	'--- P I E C E S L I S T | Public propertyes ---------------------------------------------------------------------------'
	Public Property Items() As New List(Of ChessPieces)
End Class
