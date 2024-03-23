/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
	var __webpack_exports__ = {};
	/*!***********************************************************!*\
	  !*** ../demo1/src/js/pages/features/charts/apexcharts.js ***!
	  \***********************************************************/


	// Shared Colors Definition
	// Shared Colors Definition
	const red = '#FF0000';
	const green = '#00FF00';
	const blue = '#0000FF';
	const yellow = '#FFFF00';
	const cyan = '#00FFFF';
	const pink = '#FF00FF';
	const og = '#FFCC33';
	const tam = '#66CCCC';
	const chin = '#9933CC';
	const muoi = '#333399';
	const muoimot = '#FFCCCC';
	const muoihai = '#C0C0C0';

	var color = ['#FF0000', '#00FF00', '#0000FF', '#FFFF00', '#00FFFF', '#FF00FF', '#FFCC33', '#66CCCC', '#9933CC', '#333399', '#FFCCCC', '#C0C0C0', '#582442', '#21515F'];
	// colors 
	const primary = '#6993FF';
	const success = '#1BC5BD';
	const info = '#8950FC';
	const warning = '#FFA800';
	const danger = '#F64E60';

	// Class definition
	function generateBubbleData(baseval, count, yrange) {
		var i = 0;
		var series = [];
		while (i < count) {
			var x = Math.floor(Math.random() * (750 - 1 + 1)) + 1;;
			var y = Math.floor(Math.random() * (yrange.max - yrange.min + 1)) + yrange.min;
			var z = Math.floor(Math.random() * (75 - 15 + 1)) + 15;

			series.push([x, y, z]);
			baseval += 86400000;
			i++;
		}
		return series;
	}

	function generateData(count, yrange) {
		var i = 0;
		var series = [];
		while (i < count) {
			var x = 'w' + (i + 1).toString();
			var y = Math.floor(Math.random() * (yrange.max - yrange.min + 1)) + yrange.min;

			series.push({
				x: x,
				y: y
			});
			i++;
		}
		return series;
	}

	var KTApexChartsDemo = function () {


		var _allNhanKhau_bar = function () {
			const apexChart = "#_allNhanKhau_bar";
			var namdieutra = parseInt($('#NAMDIEUTRA').val());
			
			var options = {
				series: [{
					name: 'Năm ' + (namdieutra - 1),
					data: Count_kyTruocAll
				}, {
					name: 'Năm ' + namdieutra,
					data: Count_kyDieutraAll
				}],
				chart: {
					type: 'bar',
					height: 350
				},
				plotOptions: {
					bar: {
						horizontal: false,
						columnWidth: '55%',
						endingShape: 'rounded'
					},
				},
				dataLabels: {
					enabled: false
				},
				stroke: {
					show: true,
					width: 2,
					colors: ['transparent']
				},
				xaxis: {
					categories: ['Quý 1', 'Quý 2', 'Quý 3', 'Quý 4'],
				},
				yaxis: {
					title: {
						text: 'Người'
					}
				},
				fill: {
					opacity: 1
				},
				tooltip: {
					y: {
						formatter: function (val) {
							return val + " người"
						}
					}
				},
				colors: [primary, success]
			};

			var chart = new ApexCharts(document.querySelector(apexChart), options);
			chart.render();
		}

		//thong ke chuyen nganh
		var _NhanKhau_Cn_bar = function () {
			const apexChart = "#NhanKhau_Cn_bar";
			var namdieutra = parseInt($('#NAMDIEUTRA').val());
			var quydieutra = parseInt($('#QUYDIEUTRA').val());
			var nameKyTruoc = ""; var nameKyDieuTra = "";
			if (quydieutra > 1) {
				nameKyTruoc = "Quý " + (quydieutra - 1).toString();
				nameKyDieuTra = "Quý " + quydieutra.toString();
			} else {
				nameKyTruoc = "Năm " + (namdieutra - 1).toString();
				nameKyDieuTra = "Năm " + namdieutra.toString();
			}
			var options = {
				series: [{
					name: nameKyTruoc,
					data: Count_kyTruocCn
				}, {
					name: nameKyDieuTra,
					data: Count_kyDieutraCn
				}],
				chart: {
					type: 'bar',
					height: 400
				},
				plotOptions: {
					bar: {
						horizontal: false,
						columnWidth: '55%',
						endingShape: 'rounded'
					},
				},
				dataLabels: {
					enabled: false
				},
				stroke: {
					show: true,
					width: 2,
					colors: ['transparent']
				},
				xaxis: {
					categories: Mota_chuyenganh,
				},
				yaxis: {
					title: {
						text: 'Người'
					}
				},
				fill: {
					opacity: 1
				},
				tooltip: {
					y: {
						formatter: function (val) {
							return val + " người"
						}
					}
				},
				colors: [primary, success]
			};

			var chart = new ApexCharts(document.querySelector(apexChart), options);
			chart.render();
		}
		//thong ke chuyen nganh
		var _NhanKhau_Cmkt_bar = function () {
			const apexChart = "#NhanKhau_Cmkt_bar";
			var namdieutra = parseInt($('#NAMDIEUTRA').val());
			var quydieutra = parseInt($('#QUYDIEUTRA').val());
			var nameKyTruoc = ""; var nameKyDieuTra = "";
			if (quydieutra > 1) {
				nameKyTruoc = "Quý " + (quydieutra - 1).toString();
				nameKyDieuTra = "Quý " + quydieutra.toString();
			} else {
				nameKyTruoc = "Năm " + (namdieutra - 1).toString();
				nameKyDieuTra = "Năm " + namdieutra.toString();
			}
			var options = {
				series: [{
					name: nameKyTruoc,
					data: Count_kyTruocCmkt
				}, {
					name: nameKyDieuTra,
					data: Count_kyDieutraCmkt
				}],
				chart: {
					type: 'bar',
					height: 400
				},
				plotOptions: {
					bar: {
						horizontal: false,
						columnWidth: '45%',
						endingShape: 'rounded'
					},
				},
				dataLabels: {
					enabled: false
				},
				stroke: {
					show: true,
					width: 2,
					colors: ['transparent']
				},
				xaxis: {
					categories: Mota_DmTrinhDoKyThuat,
				},
				yaxis: {
					title: {
						text: 'Người'
					}
				},
				fill: {
					opacity: 1
				},
				tooltip: {
					y: {
						formatter: function (val) {
							return val + " người"
						}
					}
				},
				colors: [primary, success]
			};

			var chart = new ApexCharts(document.querySelector(apexChart), options);
			chart.render();
		}
		//thong ke bao hiem xa hoi all
		var _NhanKhau_BhxhAll_pie = function () {
			const apexChart = "#NhanKhau_BhxhAll_pie";
			var cobaohiem = parseInt($('#COBAOHIEM').val());
			var khongcobaohiem = parseInt($('#KHONGCOBAOHIEM').val());
			var options = {
				series: [cobaohiem, khongcobaohiem],
				chart: {
					width: 420,
					type: 'pie',
				},
				labels: ['Có bảo hiểm', 'Không có bảo hiểm'],
				responsive: [{
					breakpoint: 480,
					options: {
						chart: {
							width: 800
						},
						legend: {
							position: "bottom"
						}
					}
				}],
				colors: [success,danger]
			};

			var chart = new ApexCharts(document.querySelector(apexChart), options);
			chart.render();
		}
		return {
			// public functions
			init: function () {
				_allNhanKhau_bar();
				_NhanKhau_Cn_bar();
				_NhanKhau_Cmkt_bar();
				_NhanKhau_BhxhAll_pie();
			}
		};
	}();

	jQuery(document).ready(function () {
		KTApexChartsDemo.init();
	});

	/******/
})()
	;
//# sourceMappingURL=apexcharts.js.map