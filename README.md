# LibraryManagement
## Xml, DB를 이용한 도서 대여 관리 프로그램

### 화면 구성

#### 대여, 반납 화면
![K-004](https://user-images.githubusercontent.com/59382990/84109819-784a3b80-aa5e-11ea-9161-66e199254c00.jpg)

#### 도서 관리 화면
![K-005](https://user-images.githubusercontent.com/59382990/84109860-9d3eae80-aa5e-11ea-8049-aadc6322d576.jpg)

#### 사용자 관리 화면
![K-011](https://user-images.githubusercontent.com/59382990/84111259-851c5e80-aa61-11ea-9e5e-1b4cb3bcc52d.jpg)

### 기능 테스트

#### 대여, 반납

- 대여 (DB연결 프로그램 오류 발생. 추후 확인.)
![K-007](https://user-images.githubusercontent.com/59382990/84110252-7af96080-aa5f-11ea-9d3e-07b303c6558b.jpg)

- 반납 (DB연결 프로그램 오류 발생. 추후 확인.)
![K-008](https://user-images.githubusercontent.com/59382990/84110255-7c2a8d80-aa5f-11ea-89f6-1810b865ba20.jpg)

#### 도서 관리

- 도서 추가
![K-001](https://user-images.githubusercontent.com/59382990/84110716-58b41280-aa60-11ea-9d16-8405d4e4b476.jpg)
![K-002](https://user-images.githubusercontent.com/59382990/84110720-5a7dd600-aa60-11ea-8809-1b2a388793ee.jpg)

- 기 등록된 도서번호로 도서 추가
![K-007](https://user-images.githubusercontent.com/59382990/84111009-f3145600-aa60-11ea-97dc-fb789dddd8f4.jpg)

- 도서 수정
![K-003](https://user-images.githubusercontent.com/59382990/84110722-5b166c80-aa60-11ea-8183-d85cd84fe7e3.jpg)
![K-004](https://user-images.githubusercontent.com/59382990/84110723-5baf0300-aa60-11ea-96e5-6867e2acfb23.jpg)

- 없는 도서번호로 도서 
![K-009](https://user-images.githubusercontent.com/59382990/84111102-2a830280-aa61-11ea-9598-a5f27ac2cfbd.jpg)

- 도서 삭제
![K-005](https://user-images.githubusercontent.com/59382990/84110725-5c479980-aa60-11ea-9756-c1456fa090b5.jpg)
![K-006](https://user-images.githubusercontent.com/59382990/84110727-5ce03000-aa60-11ea-972a-a89e1080db87.jpg)

- 없는 도서번호로 도서 삭제
![K-008](https://user-images.githubusercontent.com/59382990/84111049-06bfbc80-aa61-11ea-8656-e8920008e677.jpg)

#### 사용자 관리 화면 기능 확인

- 사용자 추가   
![K-012](https://user-images.githubusercontent.com/59382990/84111411-d6c4e900-aa61-11ea-96d0-5ce16c882bf1.jpg)
![K-013](https://user-images.githubusercontent.com/59382990/84111412-d7f61600-aa61-11ea-82e1-a28f970d6c7b.jpg)

- 기 등록된 사용자번호로 사용자 추가   
![K-014](https://user-images.githubusercontent.com/59382990/84111545-1f7ca200-aa62-11ea-9aff-295d0a7c07f8.jpg)

- 사용자 수정   
![K-001](https://user-images.githubusercontent.com/59382990/84111846-ab8ec980-aa62-11ea-9d96-4e17ded70baa.jpg)
![K-002](https://user-images.githubusercontent.com/59382990/84111849-acbff680-aa62-11ea-81c6-fa886c8150e2.jpg)

- 없는 사용자번호로 사용자 수정   
![K-003](https://user-images.githubusercontent.com/59382990/84111850-ad588d00-aa62-11ea-81a9-5afcdc0792f3.jpg)

- 사용자 삭제   
![K-004](https://user-images.githubusercontent.com/59382990/84111853-adf12380-aa62-11ea-8732-0fb7da5f972e.jpg)

- 없는 사용자번호로 사용자 삭제   
![K-005](https://user-images.githubusercontent.com/59382990/84111855-ae89ba00-aa62-11ea-88f8-d4dfeb50dcc6.jpg)

#### 로그파일 저장   
![K-006](https://user-images.githubusercontent.com/59382990/84112801-65d30080-aa64-11ea-9f62-2e9d298c3c72.jpg)

### 추후 개선해야 할 사항
- 화면은 무조건 중앙에 팝업되도록 한다.
- 사용자 정보 수정 시 도서 정보에도 반영되도록 해야 한다.
- 대여중인 도서가 있는 사용자일 경우 사용자 삭제가 불가하도록 해야 한다.
- 그리드 표 너비가 내용 텍스트 길이에 맞춰 변경되도록 수정하여 보기 수월하게 해야 한다.
- DB 연결 프로그램에 대여, 대출 버튼에 대한 기능에 오류발생. 수정 해야한다.

