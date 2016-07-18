<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Array Indexes</title>
</head>
<body>
    <?php
    if(isset($_GET['delimiter']) && isset($_GET['key-value-pairs']) && isset($_GET['array-size'])) {
        $delimiter = $_GET['delimiter'];
        $arraySize = intval($_GET['array-size']);
        $arr = $_GET['key-value-pairs'];

        $result = array_fill(0, $arraySize, 0);
//        for ($i = 0; $i < $arraySize; $i++) {
//            $result[$i] = 0;
//        }

        $arr = explode("\n", $arr);
        $arr = array_map('trim', $arr);
        for ($i = 0; $i < count($arr); $i++) {
            $pair = explode($delimiter, $arr[$i]);
            $key = $pair[0];
            $value = $pair[1];

            $result[$key] = $value;
        }
        for ($i = 0; $i < count($result); $i++) {
            echo $result[$i] . '<br>';
        }
    }
    ?>
    <form>
        Delimiter:<input type="text" name="delimiter">
        Array size:<input type="text" name="array-size">
        Input:<textarea name="key-value-pairs" rows="10"></textarea>
        <input type="submit" value="Submit">
    </form>
</body>
</html>