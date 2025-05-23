//#define E14_FILE_SYSTEM_01
//#define E14_FILE_SYSTEM_02
#define E14_FILE_SYSTEM_03

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 파일 시스템이란?
 * - 파일을 생성 및 제어 할 수 있는 기능을 의미한다. (즉, 파일 시스템을
 * 활용하면 반영구적으로 저장되는 데이터를 생성하는 것이 가능하다.)\
 * 
 * 프로그램은 주 기억 장치 상에서 구동되기 때문에 반영구적으로 저장되는
 * 데이터를 제어하기 위해서는 보조 기억 장치 상에 데이터를 저장 할 필요가
 * 있다. (즉, 변수는 주 기억 장치 상에 선언되기 때문에 프로그램을 종료하고
 * 나면 모든 데이터가 사라진다는 것을 알 수 있다.)
 * 
 * 파일은 보조 기억 장치에 생성되기 때문에 파일을 활용하면 간단하게
 * 반영구적으로 보관되는 데이터를 생성하는 것이 가능하다.
 * 
 * C# 파일 관련 클래스
 * - File
 * - Directory
 * 
 * C# 은 파일을 제어하기 위한 File 클래스와 디렉토리 (폴더) 를 제어하기
 * 위한 Directory 클래스를 제공하기 때문에 해당 클래스를 활용하면 손쉽게
 * 파일 등을 제어하는 것이 가능하다.
 * 
 * 스트림이란?
 * - 데이터를 주고 받을 수 있는 통로를 의미한다. (즉, 스트림이 존재하기
 * 때문에 특정 프로그램에서 다른 프로그램으로 데이터를 전달하거나 읽어들이는
 * 것이 가능하다.)
 * 
 * 스트림은 단방향이기 때문에 데이터를 기록하거나 읽어들이기 위해서는 목적에
 * 맞게 스트림을 생성 할 필요가 있다. (즉, 데이터를 기록하기 위해서는
 * 쓰기용으로 스트림을 생성해야한다는 것을 알 수 있다.)
 * 
 * 따라서, C# 으로 제작 된 프로그램에서 파일을 대상으로 데이터를 입/출력하고
 * 싶다면 스트림을 생성하면 된다는 것을 알 수 있다.
 * 
 * C# 파일 스트림 생성 방법
 * - File.Open
 * 
 * Ex)
 * FileStream oWStream = File.Open("SomeFile.txt", 
 *		FileMode.Create, FileAccess.Write);
 * 
 * 위와 같이 File.Open 메서드를 활용하면 파일을 대상으로 데이터를 입/출력
 * 할 수 있는 스트림을 생성하는 것이 가능하다. (즉, 프로그램에서 파일을
 * 개방한다는 것은 파일과 데이터를 주고 받을 수 있는 스트림을 생성하는
 * 행위라는 것을 알 수 있다.)
 */
namespace Example._03320282000301_SBS_Weekend_Engine_0003.E01.Example.Classes.Runtime.Example_14
{
	class CE01Example_14
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if E14_FILE_SYSTEM_01
			/*
			 * File.Open 메서드는 2 개의 역할을 수행한다.
			 * 
			 * 첫번째는 파일을 대상으로 데이터를 주고 받을 수 있는 스트림을
			 * 생성하는 역할이다.
			 * 
			 * 두번째는 만약 파일이 없을 경우 해당 파일을 생성해주는 역할도 
			 * 수행한다.
			 * 
			 * 단, File.Open 메서드를 통해서 파일을 생성 할 수 있는 조건은
			 * 스트림을 쓰기용으로 생성했을 경우이다. (즉, 읽기용으로는
			 * 파일을 생성하는 것이 불가능하다는 것을 알 수 있다.)
			 */
			FileStream oWStream = File.Open("../../03320282000301-SBS_Weekend_Engine_0003/E01/Example/Resources/Example_14/E01Example_14_01.txt", 
				FileMode.Create, FileAccess.Write);

			// 스트림이 생성되었을 경우
			if(oWStream != null)
			{
				/*
				 * C# 은 파일 스트림을 통해 데이터를 좀더 수월하게 입/출력하기
				 * 위한 클래스를 제공하며 StreamReader/StreamWriter 클래스는
				 * 문자열 데이터를 입/출력 할 수 있는 기능을 제공한다.
				 */
				StreamWriter oWriter = new StreamWriter(oWStream);

				for(int i = 0; i < 10; ++i)
				{
					oWriter.WriteLine("Hello, World!");
				}

				/*
				 * 스트림은 컴퓨터가 지니고 있는 자원이기 때문에 사용을 완료했을 경우
				 * 반드시 자원을 컴퓨터에게 돌려 줄 필요가 있다. (즉, 사용 완료 된
				 * 자원을 컴퓨터에게 반환하기 않을 경우 자원의 고갈에 의해 더이상 관련
				 * 기능을 사용 할 수 없는 문제가 발생한다는 것을 알 수 있다.)
				 */
				oWriter.Close();
			}

			FileStream oRStream = File.Open("../../03320282000301-SBS_Weekend_Engine_0003/E01/Example/Resources/Example_14/E01Example_14_01.txt",
				FileMode.Open, FileAccess.Read);

			// 스트림이 생성되었을 경우
			if(oRStream != null)
			{
				StreamReader oReader = new StreamReader(oRStream);

				/*
				 * EndOfStream 프로퍼티를 활용하면 특정 파일에 존재하는 데이터를
				 * 모두 읽어들이는 것이 가능하다. (즉, 해당 프로퍼티는 파일에
				 * 읽어들일 데이터가 존재하는지 검사하는 역할을 수행한다.)
				 */
				while(!oReader.EndOfStream)
				{
					string oStr = oReader.ReadLine();
					Console.WriteLine("{0}", oStr);
				}

				oReader.Close();
			}
#elif E14_FILE_SYSTEM_02
			FileStream oWStream = File.Open("../../03320282000301-SBS_Weekend_Engine_0003/E01/Example/Resources/Example_14/E01Example_14_02.bin",
				FileMode.Create, FileAccess.Write);

			// 스트림이 생성되었을 경우
			if(oWStream != null)
			{
				BinaryWriter oWriter = new BinaryWriter(oWStream);

				for(int i = 0; i < 10; ++i)
				{
					oWriter.Write(i + 1);
				}

				oWriter.Close();
			}

			FileStream oRStream = File.Open("../../03320282000301-SBS_Weekend_Engine_0003/E01/Example/Resources/Example_14/E01Example_14_02.bin",
				FileMode.Open, FileAccess.Read);

			// 스트림이 생성되었을 경우
			if(oRStream != null)
			{
				BinaryReader oReader = new BinaryReader(oRStream);

				while(oReader.PeekChar() >= 0)
				{
					int nVal = oReader.ReadInt32();
					Console.Write("{0}, ", nVal);
				}

				oReader.Close();
				Console.WriteLine();
			}
#elif E14_FILE_SYSTEM_03
			// 매개 변수가 잘못되었을 경우
			if(args.Length < 2)
			{
				Console.WriteLine("[실행 파일] [원본 파일 경로] [사본 파일 경로] 형식으로 입력해주세요.");
				return;
			}

			FileStream oRStream = File.Open(args[0],
				FileMode.Open, FileAccess.Read);

			FileStream oWStream = File.Open(args[1],
				FileMode.Create, FileAccess.Write);

			// 스트림이 생성되었을 경우
			if(oRStream != null && oWStream != null)
			{
				var oBytes = new byte[255];
				int nNumBytes = 0;

				BinaryReader oReader = new BinaryReader(oRStream);
				BinaryWriter oWriter = new BinaryWriter(oWStream);

				while((nNumBytes = oReader.Read(oBytes, 0, oBytes.Length)) > 0)
				{
					oWriter.Write(oBytes, 0, nNumBytes);
				}

				oReader.Close();
				oWriter.Close();

				Console.WriteLine("파일 복사가 완료되었습니다.");
			}
#endif
		}
	}
}
