using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
	private Camera camera;

	protected override void Awake()
	{
		base.Awake();
		camera = Camera.main; // mainCamera 태그 붙어있는 카메라를 가져온다
	}

	// 정규화, ScreenToWorldPoint 등 전처리 작업 후 CallEvent하여 실행

	public void OnMove(InputValue value)
	{
		Vector2 moveInput = value.Get<Vector2>().normalized;
		CallMoveEvent(moveInput);
	}

	public void OnLook(InputValue value)
	{
		Vector2 newAim = value.Get<Vector2>();
		Vector2 worldPos = camera.ScreenToWorldPoint(newAim); // 카메라에서 마우스 위치 -> 월드 좌표계로 변환
		newAim = (worldPos - (Vector2)transform.position).normalized; // transform position에서 world 가 어떤 방향에 있는가?

		CallLookEvent(newAim);
	}
}
