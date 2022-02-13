##  Webpack
![image](https://user-images.githubusercontent.com/42952244/132976546-7d867fc3-e8b5-46a5-94c3-78b69b9c5cbd.png)
하나의 자바스크립트 파일에 자바스크립트 뿐만 아니라 css, image 같은 여러 모듈들 몰아 넣을 수 있다.

<br/>

### source/index.js

```javascript
import hello_word from "./hello.js";
import world_word from "./world.js";
document.querySelector("#root").innerHTML = hello_word + " " + world_word;
```

[앞서](https://github.com/ji-one/TIL/blob/main/Webpack/%EC%9B%B9%ED%8C%A9_%EC%9D%B4%EC%A0%84%EA%B3%BC_%EB%AA%A8%EB%93%88%EC%9D%98_%EA%B0%9C%EB%85%90.md) `index.html`에서 작성한 내용을 index.js로 이동했다.

<br/>

```shell
npx webpack --entry ./source/index.js --output-path ./public --output-filename index_bundle.js
```

그리고 터미널에 다음과 같이 입력해 `번들러`를 생성했다.

이후 index.html에서 `<script src="./public/index_bundle.js"></script>` 를 추가한다.

이전의 코드와 동일하게 동작하지만, 내부적으로는 다르게 실행된다.

<br/>

![image](https://user-images.githubusercontent.com/42952244/132976622-15c4fba5-027f-4ff6-9436-860834d9940a.png)

기존에는 `hello.js`, `world.js` 각각을 다운로드 했지만, 지금은 `index_bundle.js` 단 하나의 파일만 다운 받고 해당 파일에 모든 기능이 들어있다.

서버에 접속할 때 한 번의 connection이 일어나기 때문에 사용자, 서버측 모두에게 좋다. 

동시에 예전 브라우저에서 동작하지 않는 import 코드를 `index_bundle.js` 안에서 알아서 처리해서 오래된 브라우저에서 동작할 수 있도록 변환해준다. 따라서 최신 브라우저의 기능 사용할 수 있으면서 오래된 브라우저까지 지원할 수 있게 되었다.
