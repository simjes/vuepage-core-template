import './css/site.css';
import 'bootstrap';
import Vue from 'vue';
import VueRouter from 'vue-router';
import VModal from 'vue-js-modal'
import Home from './components/home/home.vue';
import Counter from './components/counter/counter.vue';
import FetchData from './components/fetchdata/fetchdata.vue';

Vue.use(VueRouter);
Vue.use(VModal);

const routes = [
	{ path: '/', component: Home },
	{ path: '/counter', component: Counter },
	{ path: '/fetchdata', component: FetchData }
];

new Vue({
	el: '#app-root',
	router: new VueRouter({ mode: 'history', routes: routes }),
	render: h => h(require('./components/app/app.vue'))
});
