window.onload = function () {
	var oDiv =	document.getElementById('themeContainer');

	function onMouseWheel(ev) {/*当鼠标滚轮事件发生时，执行一些操作*/
        	// alert("asd");
        	var ev = ev || window.event;
            var down = true; // 定义一个标志，当滚轮向下滚时，执行一些操作
            down = ev.wheelDelta?ev.wheelDelta<0:ev.detail>0;

				var ul = document.getElementById("themeItemContainer");
                if(ul.style.marginLeft ==""){ul.style.marginLeft = "0px";}
           		var marginleft =  parseInt(ul.style.marginLeft);
           		var max = ul.offsetWidth - oDiv.offsetWidth + 20;
           		if(down ){
           			if(marginleft>-max-60){
           			ul.style.marginLeft  =  marginleft- 60+'px';}
           		}
           		else{
           			if(marginleft<0){
           			 ul.style.marginLeft  =  marginleft+ 60+'px';
           			}
           		}
            if(ev.preventDefault){/*FF 和 Chrome*/
                ev.preventDefault();// 阻止默认事件
            }
            return false;
        }
        addEvent(oDiv,'mousewheel',onMouseWheel);
        addEvent(oDiv,'DOMMouseScroll',onMouseWheel);
    }
    function addEvent(obj,xEvent,fn) {
    	if(obj.attachEvent){
    		obj.attachEvent('on'+xEvent,fn);
    	}else{
    		obj.addEventListener(xEvent,fn,false);
    	}
    }