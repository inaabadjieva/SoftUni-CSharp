<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Dates</title>
</head>
<body>
    <?php
        if(isset($_GET['date']) && isset($_GET['format']) && isset($_GET['commands'])) {
            $date = $_GET['date'];
            $outputFormat = $_GET['format'];
            $commands = $_GET['commands'];

            $date = DateTime::createFromFormat('d/m/Y', $date);

            $commands = array_map('trim', explode("\n", $commands));

            for ($i = 0; $i < count($commands); $i++) {
                $commandArgs = explode(" ", $commands[$i]);
                $command = $commandArgs[0];
                $value = $commandArgs[1];

                if($command == "add"){
                    $date = $date->modify("+" . $value . " day");
                }
                else{
                    $date = $date->modify("-" . $value . " day");
                }
            }
            echo $date->format($outputFormat);
        }
        ?>
    <form>
        Start Date:
        <br>
        <input type="text" name="date">
        <br>
        Output Format:
        <br>
        <input type="text" name="format">
        <br>
        Commands:
        <br>
        <textarea name="commands" rows="10"></textarea>
        <br>
        <input type="submit" value="Submit">
    </form>
</body>
</html>