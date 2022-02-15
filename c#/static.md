## Static
static 객체는 프로그램이 종료되기 전까지 메모리를 해제하지 않고 객체를 생성하지 않고도 멤버에 접근 가능 
<br/><br/>
`static` 변수
- 일반적인 변수들이 객체가 새로 생성될 때 메모리가 초기화되는 것과 다르게 해당 객체를 반복적으로 생성해도 `메모리가 유지`
    - 해당 클래스의 모든 인스턴스들의 공통적인 공유 자원
- **static 필드는 프로그램 실행 후 해당 클래스가 처음으로 사용될 때 한 번 초기화되어 계속 동일한 메모리를 사용**
- 객체가 생성되기 전에 이미 메모리가 할당되어, 생성자에서 초기화 해줄 수 없음

```
public class Test
{
    private static int static_value = 0;
    
    public Test()
    {
        static_value ++;
    }
    
    public void showStaticValue()
    {
        Console.WriteLine(static_value);
    }
}

static void Main(string[] args)
{
    for(int i=0; i<5; i++){
        Test test = new Test();
        test.showStaticValue(); // output: 1 2 3 4 5
    }
}
```
<br/><br/>
`static` 메소드
- 객체가 메모리를 할당 받기 전에 호출이 되기 때문에 객체 생성 후 메모리 할당을 받는 일반 변수에 접근 불가능
- static 메소드 내부에서 클래스 멤버 호출 불가능
- `클래스명.메소드명` 형식으로 호출. 객체 생성하지 않고 직접 호출

<br/><br/>
`static` 클래스
- 모든 클래스 멤버가 `static` 멤버로 되어 있음
- `static` 생성자를 가짐. 보통 static 필드를 초기화할 때 사용
- `static`은 인스턴스화 하지 않은 클래스이기 때문에 객체 생성 불가능

```
public static class Test
{
    static int a;
    static Test()
    {
        a = 1;
    }
    
    public static int method()
    {
        return 1;
    }
}

static void Main(string[] args)
{
    int test = Test.method();
    // Test test = new Test(); 객체 생성 불가능
}
```





참고 : https://funfunhanblog.tistory.com/51
