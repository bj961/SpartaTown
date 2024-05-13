# SpartaTown
 내일배움캠프 Chap.03 개인과제

 

## 필수 구현사항
    - [O]  캐릭터 만들기
    - [O]  캐릭터 이동
    - [O]  방 만들기
    - [O]  카메라 따라가기
    - [O]  캐릭터 애니메이션 추가
    - [ ]  이름 입력 시스템
    - [ ]  캐릭터 선택 시스템



## 선택 구현사항
    - [O]  시간 표시
    - [ ]  인게임 이름 바꾸기
    - [ ]  참석 인원 UI
    - [ ]  인게임 캐릭터 선택
    - [ ]  NPC 대화



## 진행중인 사항
- 이름 입력 시스템 및 인게임 변경 기능
- 캐릭터 선택 시스템 및 인게임 변경 기능
- 인게임 UI 구현중
    - 캐릭터 변경 UI 제외한 나머지 UI 구현
    - 기능은 미완성(해당 함수들 PlayerCharacter.cs에 구현중)
- 플레이어 캐릭터 (PlayerCharacter.cs)



### 플레이어 캐릭터
- 싱글톤 패턴 사용
- 캐릭터 생성/변경시 prefab으로 객체 생성하여 연결
- 이름 변경 시 event 통해서 캐릭터 머리 위의 UI의 이름 변경

#### 메소드
CreateCharacter(GameObject characterPrefab, string newName)

ChangeCharactger(GameObject newCharacterPrefab)

ChangeName(string newName)

UpdateNameUI()


## 진행예정 사항 (미구현내역)
- 캐릭터 선택 UI
- 참석자 출력 기능
- NPC 대화
