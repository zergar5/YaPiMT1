﻿using YaPiMT1.IO;
using YaPiMT1.Models;
using YaPiMT1.Models.Tables;
using YaPiMT1.Models.Tables.ConstTables;

var constTableReader = new ConstTableReader("../YaPiMT1/Input/");

var stringConstTable = new StringConstTable("StringConstTable.txt", constTableReader);
var stringElement = stringConstTable.FindElement("%=");
Console.WriteLine(stringElement);
stringConstTable.PrintTable();

var charConstTable = new CharConstTable("CharConstTable.txt", constTableReader);
var charElement = charConstTable.FindElement('+');
Console.WriteLine(charElement);
charConstTable.PrintTable();

var variableTable = new VariableTable();
variableTable.AddLexeme(new Lexeme("item", DataType.Undefined, "null"));
variableTable.AddLexeme(new Lexeme("25.5", DataType.Float, "25.5"));
variableTable.AddLexeme(new Lexeme("size", DataType.Int, "100"));
variableTable.AddLexeme(new Lexeme("symbol", DataType.Char, "c"));

var lexeme = variableTable.FindLexeme("item");
Console.WriteLine($"{lexeme.Name} {lexeme.Type} {lexeme.Value}");
lexeme = variableTable.FindLexeme("25.5");
Console.WriteLine($"{lexeme.Name} {lexeme.Type} {lexeme.Value}");
lexeme = variableTable.FindLexeme("size");
Console.WriteLine($"{lexeme.Name} {lexeme.Type} {lexeme.Value}");
lexeme = variableTable.FindLexeme("symbol");
Console.WriteLine($"{lexeme.Name} {lexeme.Type} {lexeme.Value}");
//lexeme = variableTable.FindLexeme("element");
//Console.WriteLine($"{lexeme.Name} {lexeme.Type} {lexeme.Value}");

variableTable.SetLexemeType("item", DataType.Float);
variableTable.SetLexemeValue("item", "99.9");
//variableTable.SetLexemeType("element", DataType.Char);

lexeme = variableTable.FindLexeme("item");
Console.WriteLine($"{lexeme.Name} {lexeme.Type} {lexeme.Value}");

Console.WriteLine();