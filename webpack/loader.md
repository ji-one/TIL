`javascript` 파일은 번들링을 잘 했는데, `css` 파일은 별도로 다운로드 되는게 아쉽다!  
`javascript` 안에 `style` 파일까지 넣으면 더 좋지 않을까? 

<br/>

webpack은 javascript가 아닌 png나 css 조차도 번들링 해줌 -> `Loader`

<br/>

## CSS Loading 
- 참고 https://webpack.js.org/guides/asset-management/#root 
```javascript
module: {
    rules: [
      {
        test: /\.css$/,
        use: ["css-loader"],
      },
    ],
  },
```
`webpack.config.js`에 다음을 추가해준다. `css-loader`는 webpack을 동작시켰을 때, 확장자가 css인 파일을 만나면 
webpack이 알아서 css 파일을 webpack 안으로 로드시켜주는 명령이다.

<br/>  

```javascript
import hello_word from "./hello.js";
import world_word from "./world.js";
import css from "./style.css";
document.querySelector("#root").innerHTML = hello_word + " " + world_word;
console.log("css", css);
```  

다음과 같이 `index.js`파일을 수정하고 실행하면 아래와 같이 console에 css가 찍히게 된다.

<br/>

![image](https://user-images.githubusercontent.com/42952244/132980509-2635fb0b-bf0a-4033-a570-1e3d2f4d8dad.png)
css에 대한 내용이 웹팩으로 주입된 것을 알 수 있다. 웹 페이지에 해당 코드를 넣으면 되겠지만 이를 자동으로 해주는 `style-loader`가 존재한다.

```javascript
module: {
    rules: [
      {
        test: /\.css$/, 
        use: ["style-loader", "css-loader"],
      },
    ],
  },
```
`style-laoder`를 추가해주면 된다.

- css-loader
  - css 파일을 읽어와서 webpack으로 가져오는 것
- style-loader
  - 그렇게 가져온 css 코드를 웹 페이지 안에 style 태그로 주입해주는 로더

<br/>

![image](https://user-images.githubusercontent.com/42952244/132981862-1862cb24-cfb7-49f2-8001-08b14496b328.png)
`style-loader`를 추가해서 다시 실행하면 `index_bundle.js`파일만 읽어왔음에도 불구하고 css가 삽입된 것을 알 수 있다.

<br/>

- 입력한 asset들을 로더를 통과시키면 가공해서 우리가 원하는 output을 만들어주는 일종의 가공 공정이 loader라고 할 수 있다.  
- rules에서 test 조건에 해당되는 파일이 발견되면 use의 로더들을 통과시켜서 처리하라는 의미이다.
- 뒤 쪽의 loader가 먼저 실행된다는 점을 주의해야한다.
