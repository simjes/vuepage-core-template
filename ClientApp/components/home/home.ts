import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import ProjectCard from '../project-card/project-card.vue';
import {ProjectType} from "../../helpers/ProjectTypes";
import {IProject} from "../../helpers/IProject";
var Parallax = require('vue-parallaxy');

@Component({
	components: { Parallax, ProjectCard }
})
export default class HomeComponent extends Vue {
	showMobile = true;
	showWeb = true;
	showBackend = true;
	showOthers = true;

	projects: IProject[] =  [
		{ id: 1, title: "mobile", type: ProjectType.Mobile },
		{ id: 2, title: "web", type: ProjectType.Web },
		{ id: 3, title: "backend", type: ProjectType.Backend },
		{ id: 4, title: "other", type: ProjectType.Others },
		{ id: 5, title: "mobile", type: ProjectType.Mobile },
		{ id: 6, title: "web", type: ProjectType.Web },
		{ id: 7, title: "backend", type: ProjectType.Backend },
		{ id: 8, title: "other", type: ProjectType.Others },
		{ id: 9, title: "mobile", type: ProjectType.Mobile },
		{ id: 10, title: "web", type: ProjectType.Web },
		{ id: 11, title: "backend", type: ProjectType.Backend },
		{ id: 12, title: "other", type: ProjectType.Others }
	];

	get filteredProjects() {
		return this.projects.filter((project) => {
			switch (project.type) {
			case ProjectType.Mobile:
				return this.showMobile;
			case ProjectType.Web:
				return this.showWeb;
			case ProjectType.Backend:
				return this.showBackend;
			case ProjectType.Others:
				return this.showOthers;
			default:
				return true;
			}
		});
	}

	get noProjects() {
		if (this.projects.length < 1) {
			return true;
		}
		return !this.showMobile && !this.showWeb && !this.showBackend && !this.showOthers;
	}
}
