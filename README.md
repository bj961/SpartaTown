# SpartaTown
 내일배움캠프 Chap.03 개인과제

 

## 필수 구현사항
    - [O]  캐릭터 만들기
    - [O]  캐릭터 이동
    - [O]  방 만들기
    - [O]  카메라 따라가기
    - [O]  캐릭터 애니메이션 추가
    - [O]  이름 입력 시스템
    - [O]  캐릭터 선택 시스템



## 선택 구현사항
    - [O]  시간 표시
    - [O]  인게임 이름 바꾸기
    - [O]  참석 인원 UI
    - [O]  인게임 캐릭터 선택
    - [ ]  NPC 대화





## 문제점 및 미완성 부분들
- sprite의 pivot위치 때문에 flip시 좌우로 크게 벌어지며 collider와 동떨어지는 문제.
   TopDown이 아닌 매트로배니아 게임용 asset (pivot위치가 중앙이 아님)을 사용하여 생긴 문제였음.
   다른 sprite를 사용 시 문제가 발생하지 않음.
- NPC 머리 위에 이름 나오지 않음.
   Text UI의 RenderMode를 World Space로 시도하다 실패 후 보류함
- StartScene에서 캐릭터 선택 후 이름 입력 창으로 넘어갈 때 2번 캐릭터 선택했을 경우 선택된 캐릭터 칸에 제대로 표시 안됨.
  캐릭터 생성은 2번 캐릭터로 정상 작동됨
- 캐릭터 이름 변경 시 참석자 UI 업데이트 되는 event 미구현. 해당 부분은 리스트를 업데이트하는 refresh 버튼으로 대체함


## 발견된 버그
- StartScene에서 캐릭터 생성 후 MainScene으로 넘어갔을 때 마우스의 위치에 따른 캐릭터 flip이 발생하지 않음.
  MainScene에서 캐릭터 변경하면 정상작동함

