# kakurasu
It is a puzzle game like Sudoku but more simple.



![Image Image](https://raw.githubusercontent.com/KDevZilla/Resource/main/Kakurasu_Screen_01.png)

# How to play
![Image Image](https://raw.githubusercontent.com/KDevZilla/Resource/main/Kakurasu_Screen_02.png)
1. You select which cell you would like to be a black cell.
2. The goal is to make the sum of the weight of the black cell 
	match the sum value of the Row/Column.
3. There are numbers that represent the weight of the cell (the blue one)
	at the top and the left side of the board.\
	In the picture, They are 1, 2, 3, 4, 5.\
   There are numbers that represent the correct sum of the weight of the cell(the orange one)
    at the right and the bottom side of the board.\
    In the picture, they are 10, 6, 10, 10, and 11 for the row
	9, 13, 8, 12, 8 for the column
4. On the picture, the first row is correct
	because there are 3 black cells on the first row
	and the summary of the 3 black cells on the first row is 10 (2 + 3 + 5)
	
5. On the picture, the first column is correct
	because there are 3 black cells on the first column
	and the summary of the 3 black cells on the first column is 9 (2 + 3 + 4)

6. You continue to select the value until the sum of all of the Rows/Columns is correct.	

# How to set up a project
1. Just download a project, it is just a small program written in C# Windows Form.
2. There are 2 projects
      Kakuarsu: This is the main project
      KakurasuTest: This is the test project
3. For testing the project, you can just run The test cases in IntegrateTest.class
4. Please look into BoardImage/Board_For_Testing.PNG as a reference, I use this board to run the test.
