using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
	[Header("IP Input")]
	public TMP_InputField ipInput;
	public TMP_InputField portInput;
	public Button connectButton;

	[Header("Message Input")]
	public TMP_InputField messageInput;
	public Button sendButton;

	[Header("Text Area")]
	public RectTransform textArea;
	public TextMeshProUGUI textPrefab;

	private Thread clientThread;
	private StreamReader reader;
	private StreamWriter writer;
	private bool isConnected;

	public static Queue<string> log = new Queue<string>();

	private void Update()
	{
		// 출력하는 부분
		if (log.Count > 0)
		{
			TextMeshProUGUI logText = Instantiate(textPrefab, textArea);
			logText.text = log.Dequeue();
		}
	}

	private void ClientThread()
	{
		TcpClient tcpClient = new TcpClient();
	}

	private void ConnectButtonClick()
	{
		// 접속 중이 아닐 경우
		if (!isConnected)
		{
			// 접속 시도
		}
		// 접속 중일 경우
		else
		{
			// 접속 해제
		}
	}
}
