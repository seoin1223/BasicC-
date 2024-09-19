# c# 기초

<br>

### 목차
1. c# 알아보기
2. c# 시작하기
3. c# 기본기 쌓기
4. 클래스 알아보기
5. c# 실력 쌓기
6. 윈도우 프로그램 만들기
7. 웹 서비스 만들기
8. 유니티로 3D 게임 만들기
9. 아두이노로 사물 인터넷 만들기

<br>

---

### C# 알아보기
---

#### 프로그래밍 언어 시작하기
1. c# 프로그래밍 언어 : 마이크로소프트에서 개발한 닷넷 프레임워크 기반 범용 목적의 다중 패러다임 프로그래밍 언어
2. 닷넷 프레임 워크
    - 웹 앱, 모바일 앱, 데스크톱   프로그램, 게임 프로그램, 사물 인터넷 프로그램 등을 만들기 위한 오픈소스, 크로스 플랫폼 개발 환경
    - Common intermediate Language(CIL) 과 Common Language Runtime(CLR) 즉, CIL을 실행할 수 있는 환경을 포함한 것이 .NET Framework 
3. 닷넷 프레임워크와 닷넷 코어
    |        | .NET Framework | .NET Core | Xamarin |
    |:--------|:--------|:--------|:------------|
    | App Models | WPF, Windows Forms, ASP.NET | UWP, ASP.NET Core |Xamarin IOS, Xamarin Android, Xamarin Forms, Xamarin Max|
    | Base Libraries | .NET Framework Class Library | CoreFx Class Library |Mono Class Library|

    - 닷넷 프레임워크 : 윈도우 환경
    - 닷넷 코어 : 여러 환경
  
4. 범용 프로그래밍 언어 : 다양한 도메인의 소프트웨어를 개발하기 위해 설계된 프로그래밍 언어
5. 다중 패러다임 언어 : 하나 이상의 프로그래밍 스타일을 지원하는 프로그래밍 언어
   
    | 명령형 | 선언형 |
    |:---:|:---:|
    |  절차적 프로그래밍 언어 |  함수형 프로그래밍 언어 |
    |  객체 지향 프로그래밍 언어 |  논리형 프로그래밍 언어 |
    | | 데이터 흐름형 프로그래밍 언어 |

<br>

#### 절차적 Vs 객체지향 프로그래밍
1. 절차적 프로그래밍 언어 : 시간의 흐름에 따라 코드를 작성하는 프로그래밍 스타일로, 대표적인 적차적 프로그래밍 언어로 C, 포트란, 베이직 등이 있음
2. 객체 지향 프로그래밍 언어 : 모든 사물을 객체로 표현하고, 객체의 속성과 메소드의 호출로 프로그램을 작성하며, 대표적인 객체지향 프로그래밍 언어로 C++, Java, C# 등이 있음


<br>

#### C#으로 만들 수 있는 것
1. 윈도우 프로그램 : Windows OS에서 동작하는 그래픽 환겨으이 프로그램
2. Unity로 만든 콘텐츠 : 2D, 3D, AR, VR, 시뮬레이션 등을 만들 수 있는 Unity 엔진을 통해 제작된 콘텐츠
3. 웹 애플리케이션 : 웹 애플리케이션 또는 웹 앱은 인터넷이나 인트라넷을 통해 웹 브라우저에서 이용할 수 있는 응용 소프트웨어p
4. 사물인터넷 연동 장치 : 네트워크 기능을 활용해 외부 장치로부터 데이터 수집 및 분석, 그래프 등으로 가시화할 수 있는 프로그램 제작

<br>

#### Visual Studio 
1. Visual Studio : 웹 사이트, 웹 앱, 모바일앱, 윈도우즈 프로그램 등을 개발할 수 있는 통합 개발 환경(IDE)
2. <details>
    <summary> 설치법</summary>
   
    1. visual Studio Communication 설치   
         <img src="https://github.com/user-attachments/assets/21abf92d-20ad-4bc2-9d82-dd08ef467488" width="500px" height="300px">
         
    2. 설치 파일 선택 후 설치 (.NET 데스크톱만 사용할 것이기 때문에 체크)  
         <img src="https://github.com/user-attachments/assets/f048cb2b-00dd-4f79-8d52-4654ce156bce" width="500px" height="300px">

    3. 설치 진행 화면   
        <img src="https://github.com/user-attachments/assets/c2b5f77a-99ca-467e-a97f-8718f6067e30" width="500px" height="300px">
</details>
       
    

