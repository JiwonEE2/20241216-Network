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
		// ����ϴ� �κ�
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
		// ���� ���� �ƴ� ���
		if (!isConnected)
		{
			// ���� �õ�
		}
		// ���� ���� ���
		else
		{
			// ���� ����
		}
	}
}
