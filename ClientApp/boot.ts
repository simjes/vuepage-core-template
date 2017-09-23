import './css/site.css';
import 'bootstrap';
import Vue from 'vue';
import Vuex from 'vuex'
import VueRouter from 'vue-router';
import Home from './components/home/home.vue';
import Counter from './components/counter/counter.vue';
import FetchData from './components/fetchdata/fetchdata.vue';

Vue.use(VueRouter);
Vue.use(Vuex);


const routes = [
	{ path: '/', component: Home },
	{ path: '/counter', component: Counter },
	{ path: '/fetchdata', component: FetchData }
];

const store = new Vuex.Store({
	state: {
		count: 0,
		projects: []
	},
	mutations: {
		increment(state) {
			state.count++;
		},
		addProjects(state, projects) {
			state.projects = projects;
		}
	}
});

//Not good practice, but gives me global access to the store without typescript hassle
window['store'] = store;

new Vue({
	el: '#app-root',
	router: new VueRouter({ mode: 'history', routes: routes }),
	render: h => h(require('./components/app/app.vue'))
});
