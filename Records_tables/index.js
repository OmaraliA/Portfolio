window.onload = function(){
	console.log('dom is ready...');
	var callButton = document.getElementById('callModal');
	var modal = document.getElementById('modal');
	var closeButton = document.getElementById('closeButton');
	callButton.onclick = function(){
		 console.log(this + ' was clicked');
		 modal.style.display = 'block';
	};
	window.onclick = function(event){
		if(event.target == modal){
			modal.style.display = 'none';
		}
	};
	closeButton.onclick = function(){
		modal.style.display = 'none';
	};

};



        

