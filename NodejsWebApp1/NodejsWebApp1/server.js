<html>
    <head>
        <style>
            *{padding: 0; margin:0;}
            canvas{background: #eee; display: block; margin: 0 auto;}
        </style>
    </head>
    <body>
        <canvas id="myCanvas" width="256" height="240"></canvas>
        <script type="text/javascript">
            let canvas = document.getElementById("myCanvas");
            let ctx = canvas.getContext("2d");
            //document.addEventListener("keydown",keyDownHandler, false);
            //document.addEventListener("keyup",keyUpHandler,false);
            let fps = 60;

            function draw () {
                setTimeout(function () {
                    requestAnimationFrame(draw);
                    ctx.fillStyle = "rgb(20,20,20)";
                    ctx.fillRect(0, 0, 256, 240);
                    ///all code goes here
                }, 1000 / fps);
}
            draw();

        </script>
    </body>
</html>