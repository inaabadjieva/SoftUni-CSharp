<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Array Indexes</title>
</head>
<body>
<?php
    if(isset($_GET['delimiter']) && isset($_GET['commands'])) {
        $delimiter = $_GET['delimiter'];
        $commands = $_GET['commands'];

        $arr = [];

        $commands = explode("\n", $commands);
        $commands = array_map('trim', $commands);
        for ($i = 0; $i < count($commands); $i++) {
            $pair = explode($delimiter, $commands[$i]);
            $command = $pair[0];
            $num = $pair[1];
            if($command == 'add')
                $arr[] = $num;
            else
                array_splice($arr, $num, 1);
        }
        for ($i = 0; $i < count($arr); $i++) {
            echo $arr[$i] . '<br>';
        }
}
?>
    <form>
        Delimiter:<input type="text" name="delimiter">
        Commands:<textarea name="commands" rows="10"></textarea>
        <input type="submit" value="Submit">
    </form>
</body>
</html>