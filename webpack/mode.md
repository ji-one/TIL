[이전에](https://github.com/ji-one/TIL/blob/main/Webpack/%EC%84%A4%EC%A0%95%ED%8C%8C%EC%9D%BC.md) 생성했던 `webpack.config.js`를 실행시키면 다음과 같은 warning이 뜬다.

```
WARNING in configuration
The 'mode' option has not been set, webpack will fallback to 'production' for this value.
Set 'mode' option to 'development' or 'production' to enable defaults for each environment.
You can also set it to 'none' to disable any default behavior. Learn more: https://webpack.js.org/configuration/mode/
```
https://webpack.js.org/configuration/mode/ 에 접속하면 모드를 확인할 수 있다. `production`이 기본값이다.   
개발을 하기 위한 것인지 실제 서비스를 위한 것인지 모드를 달리 해줄 필요가 있다.

```
mode: "development"
```
`webpack.config.js`에 mode를 추가하고 실행한다면 warning이 사라진다.

개발을 할 때와 배포를 할 때의 mode는 다를 수 밖에 없다.
이럴 경우 `webpack.config.js`는 `development` 모드, `webpack.config.prod.js`는 `production` 모드로 설정 후 평소에는 `npx webpack`을 통해 개발 모드로 실행한다.
`npx webpack --config webpack.config.prod.js`를 입력하면 `production` 모드로 번들링 시킬 수 있다.

