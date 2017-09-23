import Vue from 'vue';
import { Component, Prop } from 'vue-property-decorator';
import {IProject} from "../../helpers/IProject";

declare var store: any;

@Component
export default class ProjectCardComponent extends Vue {
	@Prop({})
	project: IProject;


	emitProjectDetails(event) {
		store.commit("increment");
		this.$emit('clickedProject', this.project);
	}
}
