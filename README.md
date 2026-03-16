# Console-game-

## Play In Browser

1. Run the task `Open Browser Game (No Port Forwarding)`.
2. This starts the local server and opens `http://127.0.0.1:5500/index.html`.
3. If a public URL gives `401`, use the port row action `Open Preview` instead of opening a public browser URL.
4. Play with arrow keys. Press `Q` to stop.

## 401 Troubleshooting

If you get `HTTP 401` on a forwarded URL, open port `5500` using `Open Preview` in VS Code.

The server task is defined in [.vscode/tasks.json](.vscode/tasks.json).