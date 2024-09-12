#include<iostream>
#include<fstream>
using std::cout;
using std::cin;
using std::endl;

//#define WRITE_TO_FILE
//#define READ_FROM_FILE

void main()
{
	setlocale(LC_ALL, "");

#ifdef WRITE_TO_FILE
	cout << "hello world" << endl;
	std::ofstream fout;		// 1)������ �����
	fout.open("file.txt", std::ios_base::app);	// 2) ��������� ����� 
	fout << "hello world" << endl;	// 3) ����� � ����� 
	fout.close();			// 4)  ��������� ����� 

	system("notepad File.txt");
#endif

	std::ifstream fin("file.txt");	// 1) �������� ������ ����� ���������� � ��������� ������
	if (fin.is_open())
	{
		// TODO: read from file
		while (!fin.eof())
		{
			const int SIZE = 256;
			char sz_buffer[SIZE]{};
			//fin >> sz_buffer;	// ��� fin, ��� �� ��� � ��� cin ������ �������� ������������,
								// � ��� ����, ����� �������� ������ � ���������, ������ cin ������������ cin.getline()
			fin.getline(sz_buffer, SIZE);
			cout << sz_buffer << endl;
		}
		fin.close();
	}
	else
	{
		std::cerr << "Error: file not found" << endl;
	}

}