## Property

- `Encapsulation`을 구현하기 위해 class의 멤버를 외부에서 직접 접근하지 못하도록 `private`, `protected`로 선언한 후 class 내부에 `getter`, `setter`를 선언하는 것이 일반적

```
class Test
{
    private int value;
    
    public void setValue(int value)
    {
        this.value = value;
    }
    
    public int getValue()
    {
        return this.value;
    }
}
```

클래스 내부 필드가 많아진다면 ? 
        수 많은 setter, getter .. readability가 떨어짐 
        
그래서 C#에서 `Property`라는 기능을 제공. 아래처럼 사용 

```
class Test
{
    private int value;
    public int _value
    {
        get { return value; }
        set { this.value = value; }
    }
}
```

좀 더 간결하려면 `자동 구현 Property` 사용

```
class Test
{
    public int value { get; set;}
}
```
---
        
❓ 그런데, `자동 구현 Property`의 경우 `public 필드`랑 무슨 차이가 있는지 의문이 들었다.   
- 관련 내용을 정리해둔 글 (https://constructionsite.tistory.com/38)
- 결론적으로, 값을 넣을 때 처리가 필요하거나 데이터 바인딩을 할 것이라면 프로퍼티를 만들어야 한다. 성능차이가 존재하지만 유의미한 차이는 아니다. 
