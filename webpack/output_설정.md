```javascript
entry: {
    index: "/source/index.js",
    about: "./source/about.js",
    // webpack이 2개의 파일 번들링 시켜줌
  },
  output: {
    path: path.resolve(__dirname, "public"),
    filename: "[name]_bundle.js",
    // 번들링하려하는 entry의 이름 [name]
  },
```
