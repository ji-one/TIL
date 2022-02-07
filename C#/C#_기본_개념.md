### 1. 닷넷프레임워크와 C# 
**C# Programming = C# Lang + Class Library** 
        
`BCL(Basic Class Library)`<br><br>
`Window Form`  
-  프로그램 제작을 위한 클래스 라이브러리<br>

`ASP.NET`
- 웹 클래스 라이브러리<br><br>

`ADO.NET`
- 데이터베이스 클래스 라이브러리<br><br>

`CLR(Common Language Runtime)`  
- 컴파일된 C# 코드(*.exe)를 실행하는 역할  
    - *.exe 파일의 코드는 IL(intermediate language), 중간언어
        - visual studio에서 C# 코드를 컴파일한 코드
        - *.exe, *.dll (assembly) 파일로 존재
        - exe 파일 자체가 바로 실행할 수 있는 네이티브 기계어가 아니라, .NET 프레임워크가 exe 파일의 내용을 읽어서 다시 OS에 맞게 재컴파일해서 실행<br><br>
        
`CTS(Common Type System)`
- C#에서 사용하는 데이터형은 실제로 객체
- int -> System.Int32
- float -> System.Single<br><br>

`CLS(Common Language Specification)`
- 닷넷 언어가 지켜야 할 최소 코드 규칙
    
---
### 2. 데이터형

암시적 데이터형 `var`  
- 대입되는 데이터에 따라 데이터형 결정<br><br>

`var`를 사용할 수 없는 예
- null 값 초기화
- 매개변수로는 사용 못함
- var는 지역변수로만 사용
- 클래스 멤버로는 사용 못함
- 연속적으로 초기화 하는 경우
    - var m = 10, n = 20;
    
---
`nullable` 형
- null을 허용하지 않는 데이터형이 null값을 허용
- 데이터형? 변수명;
- 속성
    - .HasValue // true, false
    - .Value // 읽기 전용
    
---
`boxing`
- 데이터 형을 최상위 object 형으로 변환하여 heap 메모리에 저장
- int m = 123; object obj = m;<br><br>

`unboxing`
- 힙에 저장된 형식을 다시 원래의 형식으로 변환
- int n = (int)obj;

---
`구조체`
- 구조체를 같은 구조체에 대입하게 되면 값이 복사
- 구조체는 값 형식이므로 선언만으로도 사용 가능
- new를 사용했을 때만 생성자가 호출되어 기본값으로 초기화 
- 구조체는 구조체 또는 클래스에 상속할 수 없음
- 구조체는 인터페이스를 상속하여 메서드를 구현할 수 있음
- 구조체는 값 형식이고 클래스는 참조 형식임

---
`열거형`
- 상수를 문자열로 대치하여 선언
- 상수에 의미 부여
- 형식
    - enum 열거형 명칭 {문자열1, 문자열2}
    - enum 열거형 명칭 {문자열1 = 상수, 문자열2 = 상수};
    - enum 열거형 명칭 {문자열1 = 상수, 문자열 2};
- 열거형 변수가 아닌 변수에 열거형 값을 대입할 때는 데이터형을 명시할 것

---
`참조 형식`
- class, interface, delegate, 배열, string
- 객체와 참조형 사이의 대입은 객체의 `메모리 주소`가 복사
 
---
### 3. 기본 문법
`is` 연산자
- 형식 호환을 조사하는 연산자
- `'변수' is '클래스형 or 데이터형'`
- 박싱/언박싱 변환, 참조 변환에서 사용
<br/><br/>

`as` 연산자
- 형변환과 변환 조사
- 캐스트 연산자의 역할과 불변환은 null 리턴
- 참조, 박싱, 언박싱, null 형에 사용
- `결과형 = 참조형, 언박싱, 박싱 as 변환형`
<br/><br/>

`??` null 병합 연산자
- C = A ?? B
    - A가 null이 아니면 A를 C에 대입
    - A가 null이면 B를 C에 대입
    
---
### 4. 배열 
`foreach(데이터형 변수 in 배열명(컬렉션명)){}`  
`Array.Length`
<br><br>
배열 생성과 초기화
```
// type 1
int[] array = new int[]{1, 2, 3};
int[] array = new int[3]{1, 2, 3};

// type 2
int[] array {1, 2, 3};
```   
<br><br>
다차원 배열  
```
// type 1
int[,] array1 = new int[2, 2];
int[,,] array2 = new int[2, 3, 2];

int[,] array1 = new int[,]{{1, 2}, {3, 4}};
int[,,] array2 = new int[,,]{{{1, 2}, {3, 4}}, {{5, 6}, {7, 8}}};

// type 2
int[,] array1 = new int[2, 2]{{1, 2}, {3, 4}};
int[,,] array2 = new int[2, 3, 2]{{{1, 2}, {3, 4}, {5, 6}}, {{7, 8}, {9, 10}, {11, 12}}};
 
// type 3
int[,] array2 = {{1, 2}, {3, 4}, {5, 6}};
int[,,] array3 = {{{1, 2}, {3, 4}, {5, 6}}, {{7, 8}, {9, 10}, {11, 12}}};
```
<br><br>
가변 배열 (요소의 크기가 서로 다른 배열)    
```  
// type 1
int[][] array = new int[3][];

array[0] = new int[2];
array[1] = new int[3];
array[2] = new int[4];

// or 

array[0] = new int[2]{1, 2};
array[1] = new int[3]{3, 4, 5};
array[2] = new int[4]{6, 7, 8, 9};

// or

array[0] = new int[]{1, 2};
array[1] = new int[]{3, 4, 5};
array[2] = new int[]{6, 7, 8, 9};

// type 2
int[][] array = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {4, 5, 6},
    new int[] {7, 8, 9}
};

// type 3
int[][] array = {
    new int[]{1, 2, 3},
    new int[]{4, 5, 6},
    new int[]{7, 8, 9}
}
 
```
<br><br>
배열을 함수로 전달
```

// 일차원
int[] array = {1, 2, 3, 4};

void func(int[] arr)
{
}

func(array)

// 이차원
int[,] array2 = {{1, 2, 3}, {4, 5, 6}};
SetArray(array2);

void SetArray(int[,] arr)
{
}

SetArray(new int[,] {{1, 2, 3}, {4. 5, 6}});
```

배열을 리턴한다?
- 배열이 참조하는 객체의 주소값을 리턴하는 것

배열  
- Array 클래스로부터 파생된 객체
<br><br>

배열 초기화 메서드   
```
public static void Clear(
        Array array,
        int index,
        int length
)
```
<br><br>
배열 복사 메서드 
```
public Object Clone() // 복사본은 원본과 별개의 메모리 영역 가짐
```

---
### 6. 파일 입출력
`스트림(stream)`
- 파일, 네트워크 등에서 데이터를 `바이트 단위`로 읽고 쓰는 클래스
- Stream class는 상위 기본 클래스
    - 상속클래스: FileStream, MemoryStream, NetworkStream, SqlFileStream 등
- `using System.IO` 선언<br><br>

`FileStream`
- 파일입출력을 다루는 기본 클래스
- System.Object
    + System.MarshalByRefObject
        + System.IO.Stream
            + System.IO.FileStream
- `byte[] 배열`로 데이터를 읽거나 저장함
    - 형변환이 요구됨
- StreamWriter/StreamReader + BinaryWriter/BinaryReader
- 파일 정보 설정에 사용
```
public FileStream(
    string path, // 경로
    FileMode mode, // Append, Create, CreateNew, Open, OpenOrCreate, Truncate
    FileAccess access // Read, ReadWrite, Write
)
```
<br><br>
텍스트 파일처리
- StreamWriter, StreamReader
- 텍스트 파일은 1 byte 단위, 아스키코드 기반
- 아스키코드를 유니코드로 인코딩



    
