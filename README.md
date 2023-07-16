<h1 align="center">sharp-logger</h1>

![GitHub last commit](https://img.shields.io/github/last-commit/alexandreaero/sharp-logger)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/alexandreaero/sharp-logger)
![Lines of code](https://img.shields.io/tokei/lines/github/alexandreaero/sharp-logger)

### A complete log system

## Screenshot
<img src="https://github.com/AlexandreAero/sharp-logger/assets/66020831/950b138c-74ab-46f9-9144-3d82f9bf9785" width="780" height="220">

## Usage
Create a ``SharpLogger`` instance:
```cs
SharpLogger logger = new SharpLogger("./out.md", true);
```

Log information:
```cs
logger.Log("Let's take a look at it! 👀", LogLevel.INFO);
logger.Log("Let's ignore that 😴", LogLevel.WARNING);
logger.Log("🚨 Red alert", LogLevel.ERROR);
logger.Log("Oh no 😩", LogLevel.FATAL);

logger.Log("I can do more, {0} + {1} = {2}", LogLevel.INFO, "🌱", "💦", "🌽");
```

Close the logger:
```cs
logger.Close();
```

Output:
```
2023-06-19 18:00:32 [INFO] Let's take a look at it! 👀
2023-06-19 18:00:32 [WARNING] Let's ignore that 😴
2023-06-19 18:00:32 [ERROR] 🚨 Red alert
2023-06-19 18:00:32 [FATAL] Oh no 😩
2023-06-19 18:00:32 [INFO] I can do more, 🌱 + 💦 = 🌽
```
