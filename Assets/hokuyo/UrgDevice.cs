using UnityEngine;
using System.Collections;

public class UrgDevice : MonoBehaviour {

	public enum CMD
	{
		// https://www.hokuyo-aut.jp/02sensor/07scanner/download/pdf/URG_SCIP20.pdf
		VV, PP, II, // 传感器信息请求命令（3种） 센서 정보 요청 명령(3종류)
        BM, QT, //测量开始/结束命令 측정 시작/종료 명령
        MD, GD, // 距离请求命令（2种） 거리요구명령(2종)
        ME //距离和接收光强度请求命令 거리 및 수신 광도 요구 명령
    }

	public static string GetCMDString(CMD cmd)
	{
		return cmd.ToString();
	}
}
