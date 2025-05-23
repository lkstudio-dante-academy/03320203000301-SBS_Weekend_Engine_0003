//#define E10_CLASS_01
//#define E10_CLASS_02
#define E10_CLASS_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 클래스란?
 * - 변수 및 메서드 등을 하나로 묶어서 관리 할 수 있는 기능을 의미한다. (즉,
 * 클래스를 활용하면 연관 된 데이터와 메서드를 하나의 데이터를 묶어서 
 * 제어하는 것이 가능하다.)
 * 
 * C# 은 객체 지향 프로그래밍 패러다임을 지원하며 객체 지향 프로그램의
 * 핵심이 되는 사물 (객체) 을 클래스를 통해서 표현하는 것이 가능하다. (즉,
 * 사물이 지니고 있는 특징을 크게 속성과 행위로 나누어서 사물의 속성은
 * 변수를 통해서 표현하고 사물의 행위는 메서드를 통해서 표현하는 것이
 * 가능하다.)
 * 
 * C# 클래스 정의 방법
 * - class + 클래스 이름 + 클래스 멤버 (변수, 메서드 등등...)
 * 
 * Ex)
 * class CSomeClass
 * {
 *		int m_nVal;
 *		
 *		void SomeMethod()
 *		{
 *				// Do Something
 *		}
 * }
 * 
 * CSomeClass oSomeObj = new CSomeClass();
 * 
 * 위와 같이 정의 된 클래스는 자료형처럼 사용하는 것이 가능하며 new 키워드를
 * 통해 사물 (객체) 을 생성하는 것이 가능하다. (즉, 클래스는 사물을 생성하기
 * 위한 틀처럼 활용된다는 것을 알 수 있다.)
 * 
 * 객체 지향 프로그래밍이란?
 * - 프로그램의 구조를 설계하기 위한 방법 중 하나로서 특정 역할을 수행하는
 * 사물을 정의하고 사물과 사물 간에 상호 작용을 통해서 프로그램의 목적을
 * 달성하는 설계 방법을 의미한다. (즉, 객체 지향 프로그래밍은 사물을 
 * 정의하는 것이 가장 중요하다는 것을 알 수 있다.)
 */
namespace Example._03320282000301_SBS_Weekend_Engine_0003.E01.Example.Classes.Runtime.Example_10
{
	class CE01Example_10
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if E10_CLASS_01
			/*
			 * 객체 하위에 존재하는 멤버에 접근하고 싶다면 . (멤버 접근 연산자) 를
			 * 활용하면 된다. (즉, 해당 연산자를 활용하면 특정 객체가 지니고 있는
			 * 변수 및 메서드 등에 접근하는 것이 가능하다.)
			 */
			CE01Character_10 oCharacterA = new CE01Character_10();
			oCharacterA.m_nLV = 1;
			oCharacterA.m_nHP = 25;
			oCharacterA.m_nATK = 5;

			CE01Character_10 oCharacterB = new CE01Character_10();
			oCharacterB.m_nLV = 20;
			oCharacterB.m_nHP = 250;
			oCharacterB.m_nATK = 100;

			Console.WriteLine("=====> 캐릭터 A <=====");
			oCharacterA.ShowInfo();

			Console.WriteLine("\n=====> 캐릭터 B <=====");
			oCharacterB.ShowInfo();
#elif E10_CLASS_02
			CE01Character_10 oCharacterA = new CE01Character_10();
			oCharacterA.m_nLV = 1;
			oCharacterA.m_nHP = 25;
			oCharacterA.m_nATK = 5;

			CE01Character_10 oCharacterB = new CE01Character_10(20, 250, 100);

			Console.WriteLine("=====> 캐릭터 A <=====");
			oCharacterA.ShowInfo();

			Console.WriteLine("\n=====> 캐릭터 B <=====");
			oCharacterB.ShowInfo();
#elif E10_CLASS_03
			/*
			 * 아래와 같이 접근자 메서드를 통해서 클래스 외부에서는 간접적으로
			 * 특정 멤버를 제어하는 것이 가능하다.
			 */
			CE01Character_10 oCharacterA = new CE01Character_10();
			oCharacterA.SetLV(1);
			oCharacterA.SetHP(25);
			oCharacterA.SetATK(5);

			CE01Character_10 oCharacterB = new CE01Character_10(20, 250, 100);

			Console.WriteLine("=====> 캐릭터 A <=====");
			oCharacterA.ShowInfo();

			Console.WriteLine("\n=====> 캐릭터 B <=====");
			oCharacterB.ShowInfo();
#endif
		}

#if E10_CLASS_01
		/** 캐릭터 */
		private class CE01Character_10
		{
			public int m_nLV = 0;
			public int m_nHP = 0;
			public int m_nATK = 0;

			/** 정보를 출력한다 */
			public void ShowInfo()
			{
				/*
				 * 멤버 메서드는 동일한 클래스에 존재하는 다른 멤버에 접근하는
				 * 것이 가능하다. (즉, 멤버 메서드가 호출 될 때 동일한 클래스에
				 * 존재하는 멤버는 입력 값으로 전달 할 필요가 없다.)
				 * 
				 * 이때, 멤버 메서드에서 접근하는 멤버는 해당 메서드를 호출한
				 * 객체에 존재하는 멤버라는 것을 알 수 있다. (즉, 어떤 객체의
				 * 멤버 메서드를 호출하는지에 따라 접근하는 멤버가 다르다는 것을
				 * 의미한다.)
				 */
				Console.WriteLine("LV : {0}", m_nLV);
				Console.WriteLine("HP : {0}", m_nHP);
				Console.WriteLine("ATK : {0}", m_nATK);
			}
		}
#elif E10_CLASS_02
		/** 캐릭터 */
		private class CE01Character_10
		{
			public int m_nLV = 0;
			public int m_nHP = 0;
			public int m_nATK = 0;

			/*
			 * 생성자란?
			 * - 특정 클래스를 통해 객체를 생성 할 때 가장 먼저 호출되는
			 * 특별한 메서드를 의미한다. (즉, 생성자를 활용하면 객체를
			 * 생성과 동시에 특정 값으로 초기화하는 것이 가능하다.)
			 * 
			 * 생성자는 객체를 초기화하는 용도로 사용되기 때문에 모든 클래스는
			 * 반드시 생성자를 구현 할 필요가 있다. (즉, 객체가 생성되기 위해서는
			 * 반드시 생성자가 호출되어야한다는 것을 알 수 있다.)
			 * 
			 * 만약, 특정 클래스에 생성자를 구현하지 않았을 경우 C# 컴파일러에
			 * 의해서 자동으로 기본 생성자가 구현된다.
			 * 
			 * 단, 클래스에 생성자가 하나라도 존재 할 경우 C# 컴파일러는 더이상
			 * 기본 생성자를 자동으로 구현해주지 않기 때문에 기본 생성자가 필요하다면
			 * 직접 구현 할 필요가 있다.
			 * 
			 * 위임 생성자란?
			 * - 생성자에서 다른 생성자를 호출해주는 기능을 의미한다. (즉, 위임 생성자를
			 * 활용하면 객체를 초기화하기 위한 명령문의 중복을 줄이는 것이 가능하다.)
			 * 
			 * this 키워드란?
			 * - 객체 자신을 참조하는 키워드를 의미한다. (즉, 해당 키워드가 존재하기
			 * 때문에 멤버 메서드에서는 동일한 객체에 존재하는 다른 멤버에 접근하는
			 * 것이 가능하다.)
			 * 
			 * Ex)
			 * class CSomeClass
			 * {
			 *		int m_nVal;
			 *		
			 *		void SomeMethod()
			 *		{
			 *			m_nVal = 0;
			 *			this.m_nVal = 0;
			 *		}
			 * }
			 */
			/** 생성자 */
			public CE01Character_10() : this(0, 0, 0)
			{
				// Do Something
			}

			/** 생성자 */
			public CE01Character_10(int a_nLV, int a_nHP, int a_nATK)
			{
				m_nLV = a_nLV;
				m_nHP = a_nHP;
				m_nATK = a_nATK;
			}

			/** 정보를 출력한다 */
			public void ShowInfo()
			{
				Console.WriteLine("LV : {0}", m_nLV);
				Console.WriteLine("HP : {0}", m_nHP);
				Console.WriteLine("ATK : {0}", m_nATK);
			}
		}
#elif E10_CLASS_03
		/*
		 * 접근 제어 지시자 (한정자) 란?
		 * - 클래스에 선언 된 멤버의 보호 수준을 의미한다. (즉, 접근 제어 지시자를
		 * 활용하면 특정 멤버에 접근 할 수 있는 범위를 제한하는 것이 가능하다.)
		 * 
		 * C# 주요 접근 제어 지시자 종류
		 * - public			<- 클래스 내부와 외부에서 모두 접근 허용
		 * - protected		<- 클래스 내부와 자식 클래스에서 접근 허용
		 * - private		<- 클래스 내부에서 접근 허용
		 * 
		 * Ex)
		 * class CSomeClass
		 * {
		 *		private int m_nVal;
		 * }
		 * 
		 * CSomeClass oSomeObj = new CSomeClass();
		 * oSomeObj.m_nVal = 0;
		 * 
		 * 위의 경우 m_nVal 변수는 private 수준으로 지정 되어있기 때문에 클래스
		 * 외부에서 접근이 불가능하다는 것을 알 수 있다. (즉, 컴파일 에러가
		 * 발생한다.)
		 * 
		 * 일반적으로 멤버 변수는 private 수준으로 보호하는 것이 관례이며
		 * 만약, 외부에서 해당 변수에 접근 할 필요가 있을 경우 접근자 메서드를
		 * 제공해야한다. (즉, 클래스 외부에서는 접근자 메서드를 통해 private
		 * 수준으로 보호되고 있는 멤버에 간접적으로 접근하는 것이 가능하다.)
		 */
		/** 캐릭터 */
		private class CE01Character_10
		{
			private int m_nLV = 0;
			private int m_nHP = 0;
			private int m_nATK = 0;

			/** 생성자 */
			public CE01Character_10() : this(0, 0, 0)
			{
				// Do Something
			}

			/** 생성자 */
			public CE01Character_10(int a_nLV, int a_nHP, int a_nATK)
			{
				m_nLV = a_nLV;
				m_nHP = a_nHP;
				m_nATK = a_nATK;
			}

			/** 레벨을 반환한다 */
			public int GetLV()
			{
				return m_nLV;
			}

			/** 체력을 반환한다 */
			public int GetHP()
			{
				return m_nHP;
			}

			/** 공격력을 반환한다 */
			public int GetATK()
			{
				return m_nATK;
			}

			/** 레벨을 변경한다 */
			public void SetLV(int a_nLV)
			{
				m_nLV = a_nLV;
			}

			/** 체력을 변경한다 */
			public void SetHP(int a_nHP)
			{
				m_nHP = a_nHP;
			}

			/** 공격력을 변경한다 */
			public void SetATK(int a_nATK)
			{
				m_nATK = a_nATK;
			}

			/** 정보를 출력한다 */
			public void ShowInfo()
			{
				Console.WriteLine("LV : {0}", m_nLV);
				Console.WriteLine("HP : {0}", m_nHP);
				Console.WriteLine("ATK : {0}", m_nATK);
			}
		}
#endif
	}
}
