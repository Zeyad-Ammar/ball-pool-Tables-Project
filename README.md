<h1>Pool Table Rental Management System</h1>

<p>A robust and user-friendly Windows Forms (WinForms) desktop application built in C# to manage time and billing for pool and billiard rental places.</p>

<h2>🎱 Overview</h2>
<p>This project simplifies the management of pool tables by tracking play time, calculating rental fees based on customizable hourly rates, and managing customer sessions. The application features a main dashboard that monitors up to 8 pool tables simultaneously, utilizing custom User Controls to keep the code modular, clean, and scalable.</p>

<h2>✨ Features</h2>
<ul>
  <li><strong>Multi-Table Management:</strong> Manage up to 8 pool tables on a single dashboard.</li>
  <li><strong>Flexible Time Modes:</strong>
    <ul>
      <li><strong>Open Time:</strong> Players can play as long as they want, and the total fee is calculated at the end.</li>
      <li><strong>Fixed Time:</strong> Set a specific duration (hours/minutes). The system will play an alert sound (<code>endTime.wav</code>) and automatically stop when the time is up.</li>
    </ul>
  </li>
  <li><strong>Pause &amp; Resume:</strong> Easily pause a table's timer in case of interruptions (e.g., power outages or breaks) and resume without having to calculate separate billing periods.</li>
  <li><strong>Automatic Fee Calculation:</strong> Calculates exact fees based on the elapsed time in seconds and the table's specific hourly rate.</li>
  <li><strong>Detailed Session Summaries:</strong> When a session ends, a summary window displays the table name, player name, total time played, and the final cost.</li>
  <li><strong>Custom User Controls (<code>ctrlPoolTable</code>):</strong> Highly modular design making it easy to add more tables or customize individual table properties (like hourly rates or names) directly from the properties window.</li>
</ul>

<h2>📸 Screenshots</h2>

<h3>Main Dashboard</h3>
<p>The main form displaying all 8 pool table controls actively ready for use.</p>
<p><img width="1363" height="744" alt="image" src="https://github.com/user-attachments/assets/8e22e458-2596-439b-b57e-a3efc49039e7" />
</p>

<h3>Single Table Control</h3>
<p>The custom user control representing an individual pool table, showing the current player, elapsed time, and Start/End/Pause controls.</p>
<p><img width="352" height="365" alt="image" src="https://github.com/user-attachments/assets/d53399fa-5455-429f-a318-e9f4a025507c" />
</p>

<h3>Rent Details Form</h3>
<p>The dialog box that appears when starting a session, allowing the operator to input the player's name and choose between Open Time or a specific duration.</p>
<p><img width="580" height="361" alt="image" src="https://github.com/user-attachments/assets/248f6944-26b3-44ce-8f70-ce2a403bd00e" />
</p>

<h2>🛠️ Code Structure</h2>
<p>The project is built upon three main components:</p>
<ol>
  <li><strong><code>frmMain</code></strong>: The main application window hosting the individual pool table controls. It subscribes to custom events to display billing summaries when a table's session ends.</li>
  <li><strong><code>ctrlPoolTable</code></strong>: A reusable User Control handling the logic for the timer, fee calculation, state management (Started, Paused, Stopped), and sound alerts. It exposes properties like <code>tableName</code> and <code>hourlyRate</code> for easy configuration.</li>
  <li><strong><code>frmRentDetails</code></strong>: A modal form for capturing session details (Player Name, Hours, Minutes, Open Time) before starting the timer. Uses delegates/actions to pass data back to the User Control.</li>
</ol>

<h2>🚀 How to Use</h2>
<ol>
  <li>Run the application.</li>
  <li>Click <strong>Start</strong> on an available pool table.</li>
  <li>In the Rent Details dialog, enter the <strong>Player Name</strong>.</li>
  <li>Check <strong>Open Time</strong> for an indefinite session, or uncheck it to specify the exact <strong>Hours</strong> and <strong>Minutes</strong>. Click <strong>OK</strong>.</li>
  <li>The timer will begin. If an interruption occurs, click <strong>Pause</strong> and then <strong>Start</strong> to resume.</li>
  <li>Once the session is over (or if the fixed time runs out), click <strong>End</strong>. </li>
  <li>A prompt will display the final fee and session details. The table will automatically reset for the next player.</li>
</ol>

<h2>💻 Requirements</h2>
<ul>
  <li>Visual Studio (or any C# IDE supporting WinForms)</li>
  <li>.NET Framework or .NET Core / .NET 5+ (WinForms compatible)</li>
  <li>Windows Operating System</li>
</ul>
